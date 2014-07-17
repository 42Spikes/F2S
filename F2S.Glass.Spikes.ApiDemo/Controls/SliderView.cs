using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Android.Views.Animations;
using Java.Lang;
using Math = System.Math;

namespace F2S.Glass.Spikes.ApiDemo.Controls
{
    public class SliderView : FrameLayout
    {
        private SliderView slider;
        private ImageView indeterminateSlider;
        private float animatedCount = 0.0F;
        private int count = 0;
        private ObjectAnimator countAnimator;
        private float index = 0.0F;
        private ViewPropertyAnimator progressAnimator;
        private float slideableScale = 1.0F;
        private bool sliderShowing = true;
        private bool sliderWasShowing = false;
        private IRunnable hideSliderRunnable;

        public SliderView(Context paramContext)
            : this(paramContext, null)
        {

        }
        public SliderView(Context paramContext, IAttributeSet paramAtributeSet)
            : this(paramContext, null, 0)
        {

        }

        public SliderView(Context paramContext, IAttributeSet paramAtributeSet, int paramint)
            : base(paramContext, paramAtributeSet, paramint)
        {
            this.hideSliderRunnable = new Runnable(() => hideSlider(true));
            LayoutInflater.From(Context).Inflate(Resource.Layout.slider, this);
            slider = (SliderView)FindViewById(Resource.Id.slider_control);
            indeterminateSlider = ((ImageView)FindViewById(Resource.Id.indeterminate_slider));
            hideSlider(false);
            hideIndeterminateSlider(false);
        }

        private void animateCountTo(float paramFloat)
        {
            if ((this.countAnimator != null) && (this.countAnimator.IsRunning))
                this.countAnimator.Cancel();

            float[] arrayOfFloat = new float[2];
            arrayOfFloat[0] = this.animatedCount;
            arrayOfFloat[1] = paramFloat;
            this.countAnimator = ObjectAnimator.OfFloat(this, "animatedCount", arrayOfFloat);
            this.countAnimator.SetDuration(300L);
            this.countAnimator.Start();
        }

        private const int slider_bar_height = 12;
        private const long slider_in_out_animation_duration_ms = 300;
        private int getBaseSliderWidth()
        {
            return Math.Max((int)(Resources.DisplayMetrics.WidthPixels / this.animatedCount), 40);
        }

        private void hideIndeterminateSlider(bool paramBoolean)
        {
            int i = Resources.GetDimensionPixelSize(slider_bar_height); // Resource.Dimens.slider_bar_height);

            if (paramBoolean)
            {
                this.indeterminateSlider.Animate().TranslationY(i).SetDuration(slider_in_out_animation_duration_ms); //Resources.GetInteger(Resource.Integer.slider_in_out_animation_duration_ms));
                return;
            }

            this.indeterminateSlider.TranslationY = i;
        }


        private void hideSlider(bool paramBoolean)
        {
            if (!this.sliderShowing)
                return;

            int i = Resources.GetDimensionPixelSize(slider_bar_height); //Resource.dimens.slider_bar_height);
            this.slider.Animate().Cancel();

            if (paramBoolean)
                this.slider.Animate().TranslationY(i).SetDuration(slider_in_out_animation_duration_ms); //Resources.GetInteger(Resource.Integers.slider_in_out_animation_duration_ms));

            while (true)
            {
                this.sliderShowing = false;
                this.slider.TranslationY = i;
                return;
            }
        }

        private void hideSliderAfterTimeout()
        {
            RemoveCallbacks(this.hideSliderRunnable);
            PostDelayed(this.hideSliderRunnable, 2000L);
        }

        private void setProportionalIndex(float paramFloat, int paramInt, bool paramBoolean)
        {
            if (this.count < 2)
                hideSlider(true);

            while (true)
            {
                this.index = paramFloat;
                float f1 = 1.0F / this.slideableScale;
                float f2 = (0.5F + this.index - f1 / 2.0F) * (Resources.DisplayMetrics.WidthPixels / this.count);
                if (paramInt != 0)
                    this.slider.Animate().TranslationX(f2).SetDuration(paramInt).SetInterpolator(new AccelerateDecelerateInterpolator());

                while (paramBoolean)
                {
                    showSlider(true);
                    hideSliderAfterTimeout();
                    this.slider.TranslationX = f2;
                }
            }
        }

        private void showIndeterminateSlider(bool paramBoolean)
        {
            if (paramBoolean)
            {
                this.indeterminateSlider.Animate().TranslationY(0.0F).SetDuration(slider_in_out_animation_duration_ms); //Resources.GetInteger(Resource.integer.slider_in_out_animation_duration_ms));
                return;
            }

            this.indeterminateSlider.TranslationY = 0.0f;
        }

        private void showSlider(bool paramBoolean)
        {
            RemoveCallbacks(this.hideSliderRunnable);

            if (this.sliderShowing)
                return;

            this.slider.Animate().Cancel();

            if (paramBoolean)
                this.slider.Animate().TranslationY(0.0F).SetDuration(slider_in_out_animation_duration_ms); //Resources.GetInteger(Resource.integer.slider_in_out_animation_duration_ms));

            while (true)
            {
                this.sliderShowing = true;
                this.slider.TranslationY = 0.0f;
                return;
            }
        }

        private void updateSliderWidth(bool paramBoolean)
        {
            if (this.count < 2)
            {
                hideSlider(true);
                return;
            }

            FrameLayout.LayoutParams localLayoutParams = (FrameLayout.LayoutParams) this.slider.LayoutParameters;
            localLayoutParams.Width = ((int)(1.0F / this.slideableScale * getBaseSliderWidth()));
            localLayoutParams.LeftMargin = 0;
            this.slider.LayoutParameters = localLayoutParams;

            if (paramBoolean)
                showSlider(true);

            setProportionalIndex(this.index, 0, paramBoolean);
        }

        public void dismissManualProgress()
        {
            hideSlider(true);
        }

        float getAnimatedCount()
        {
            return this.animatedCount;
        }

        void setAnimatedCount(float paramFloat)
        {
            setAnimatedCount(paramFloat, true);
        }

        void setAnimatedCount(float paramFloat, bool paramBoolean)
        {
            this.animatedCount = paramFloat;
            updateSliderWidth(paramBoolean);
        }

        public void setCount(int paramInt)
        {
            setCount(paramInt, true);
        }

        public void setCount(int paramInt, bool paramBoolean)
        {
            hideIndeterminateSlider(true);
            hideSlider(true);
            this.count = paramInt;
            this.index = Math.Max(Math.Min(this.index, paramInt - 1), 0.0F);

            if (paramBoolean)
            {
                animateCountTo(paramInt);
                return;
            }

            setAnimatedCount(paramInt, false);
        }

        public void setManualProgress(float paramFloat)
        {
            setManualProgress(paramFloat, false);
        }

        public void setManualProgress(float paramFloat, bool paramBoolean)
        {
            hideIndeterminateSlider(true);
            showSlider(false);
            int i = Resources.DisplayMetrics.WidthPixels;
            FrameLayout.LayoutParams localLayoutParams = (FrameLayout.LayoutParams) this.slider.LayoutParameters;
            localLayoutParams.Width = i;
            localLayoutParams.SetMargins(-i, 0, 0, 0);
            this.slider.LayoutParameters = localLayoutParams;

            if (paramBoolean)
            {
                this.slider.Animate().TranslationX(paramFloat * i);
                return;
            }

            this.slider.TranslationX = paramFloat * i;
        }

        public void setProportionalIndex(float paramFloat)
        {
            setProportionalIndex(paramFloat, 0, true);
        }

        public void setProportionalIndex(float paramFloat, int paramInt)
        {
            setProportionalIndex(paramFloat, paramInt, true);
        }

        public void setScale(float paramFloat)
        {
            this.slideableScale = paramFloat;
            updateSliderWidth(true);
        }

        public void startIndeterminate()
        {
            int i = Resources.DisplayMetrics.WidthPixels;
            FrameLayout.LayoutParams localLayoutParams = (FrameLayout.LayoutParams)this.slider.LayoutParameters;
            localLayoutParams.Width= i;
            localLayoutParams.SetMargins(0, 0, 0, 0);
            this.slider.LayoutParameters = localLayoutParams;

            if (this.sliderShowing)
            {
                this.sliderWasShowing = true;
                hideSlider(true);
            }

            showIndeterminateSlider(true);
            ((AnimationDrawable)this.indeterminateSlider.Background).Start();
        }

        public void startProgress(long paramLong)
        {
            startProgress(paramLong, new AccelerateDecelerateInterpolator());
        }

        public void startProgress(long paramLong, Animator.IAnimatorListener paramAnimatorListener)
        {
            startProgress(paramLong, new AccelerateDecelerateInterpolator(), paramAnimatorListener);
        }

        public void startProgress(long paramLong, ITimeInterpolator paramTimeInterpolator)
        {
            startProgress(paramLong, paramTimeInterpolator, null);
        }

        public void startProgress(long paramLong, ITimeInterpolator paramTimeInterpolator, Animator.IAnimatorListener paramAnimatorListener)
        {
            hideIndeterminateSlider(true);
            this.slider.TranslationX = 0.0F;
            showSlider(false);
            int i = Resources.DisplayMetrics.WidthPixels;
            FrameLayout.LayoutParams localLayoutParams = (FrameLayout.LayoutParams) this.slider.LayoutParameters;
            localLayoutParams.Width= i;
            localLayoutParams.SetMargins(-i, 0, 0, 0);
            this.slider.LayoutParameters = localLayoutParams;
            this.progressAnimator = this.slider.Animate().TranslationX(i).SetDuration(paramLong).SetInterpolator(paramTimeInterpolator).SetListener(paramAnimatorListener);
        }

        public void stopIndeterminate()
        {
            if (this.sliderWasShowing)
                showSlider(true);

            ((AnimationDrawable)this.indeterminateSlider.Background).Stop();
            hideIndeterminateSlider(true);
        }

        public void stopProgress()
        {
            if (this.progressAnimator != null)
                this.progressAnimator.Cancel();

            hideSlider(true);
        }

    }
}