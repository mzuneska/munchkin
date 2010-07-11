using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using Munchkin.Cards;

namespace Munchkin.Utilities
{
    class CardLoader
    {
        public CardLoader() { }

        public List<Card> Load(Card.Genre card_genre)
        {
            XPathDocument doc = new XPathDocument("Cards.xml");
            XPathNavigator navigator = doc.CreateNavigator();
            String xpath = String.Format("/cards/{0}", card_genre.ToString().ToLower());
            XPathNodeIterator nodes = navigator.Select(xpath);

            List<Card> cards = new List<Card>();
            foreach (XPathNodeIterator node in nodes)
            {
                string name = node.Current.GetAttribute("name", "");
                object card = Activator.CreateInstance(null, Classify(name));
                cards.Add(CardFactory(card as Card, node.Current));
            }

            
            return cards;
        }

        private string Classify(string to_classify)
        {
            return to_classify.Replace(" ", "");
        }

        private Card CardFactory(Card card, XPathNavigator node)
        {   
            switch (node.Name)
            {
                default:
            }
        }

        private Card CreateMonsterCard(Card card, XPathNavigator node)
        {
            throw new NotImplementedException();
        }

        private Card CreateItemCard(Card card, XPathNavigator node)
        {
            throw new NotImplementedException();
        }

        private Card CreateCurseCard(Card card, XPathNavigator node)
        {
            throw new NotImplementedException();
        }

        private Card CreateRaceCard(Card card, XPathNavigator node)
        {
            throw new NotImplementedException();
        }

        private Card CreateClassCard(Card card, XPathNavigator node)
        {
            throw new NotImplementedException();
        }

        private Card CreateSpecialtyCard(Card card, XPathNavigator node)
        {
            throw new NotImplementedException();
        }
    }
}
