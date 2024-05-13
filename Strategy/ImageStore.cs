using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class ImageStore
    {
        private readonly ICompressor _compressor;
        private readonly IFilter _filter;

        public ImageStore(ICompressor compressor, IFilter filter)
        {
            this._compressor = compressor;
            this._filter = filter;
        }

        public void Store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Apply(fileName);
        }
    }
}