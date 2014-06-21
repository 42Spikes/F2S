using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.App;
using Android.Glass.Widget;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.ApiDemo.Cards
{
    public class CardAdapter : CardScrollAdapter
    {
        private List<Card> _cards;

        public CardAdapter(IEnumerable<Card> cards)
        {
            _cards = cards.ToList();
        }

        public override int GetPosition(Java.Lang.Object card)
        {
            return _cards.Contains(card) ? _cards.IndexOf((Card)card) : AdapterView.InvalidPosition;
        }

        public override int Count
        {
            get { return _cards.Count(); }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return _cards[position];
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            return _cards[position].GetView(convertView, parent);
        }

        public override int GetItemViewType(int position)
        {
            return _cards[position].ItemViewType;
        }

        public override int ViewTypeCount
        {
            get { return Card.ViewTypeCount; }
        }
    }
}