using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace IteratorPattern
{
    public class BrowseHistory
    {
        private readonly List<string> _urls = new();
        private readonly string[] _urlss = new string[6]; //array of four elemets

        private int _count;

        public void Push(string url)
        {
            _urls.Add(url); //add to the list
            int arrayNextItemCount = _count++;
            _urlss[arrayNextItemCount] = url; //add to the array
        }

        //return last item and remove it for the array object
        public string Pop()
        {
            _count--;
            return _urlss[--_count];

        }

        //return last item and remove it for the list object
        //public string Pop()        {
        //    var lastIndex = _urls.Count - 1;
        //    var lastUrl = _urls[lastIndex];
        //    _urls.RemoveAt(lastIndex);
        //    return lastUrl;
        //}

        //public list<string> geturls()
        //{
        //    return _urls;
        //}

        //public List<string> GetUrls => urls; >>> dont need this anymore

        public IIterator<string> CreateIterator()
        {
            return new ArrayIterator(this);
            // or 
            //return new ListIterator(this);

        }


        //nested class to see the private probs (urls) of BrowseHistory which is urls
        //note: we made it private to prevent creaing it a lone by consumer as it should be created using BrowseHistory.CreateIterator
        private class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }


            public string Current()
            {
                return (_history._urls[_index]);
            }

            public bool HasNext()
            {
                return (_index <_history._urls.Count);
            }

            public void Next()
            {
                _index++;
            }
        }

        private class ArrayIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _counter;

            public ArrayIterator(BrowseHistory history)
            {
                _history = history;
            }


            public string Current()
            {
                return (_history._urlss[_counter]);
            }

            public bool HasNext()
            {
                //it answer the question, if the next Counter is less than 4 
                return (_counter < _history._urlss.Length);
            }

            public void Next()
            {
                _counter++;
            }
        }


    }

    
}
