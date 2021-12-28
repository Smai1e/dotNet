using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public class Plant
    {
        public string _genus;
        public string _variety;
        public byte[] _img;
        public string _decorative_qualities;


        public Plant(string genus, string variety, byte[] img, string decorative_qualities)
        {
            _genus = genus;
            _variety = variety;
            _img = img;
            _decorative_qualities = decorative_qualities;

            Database.AddNewPlant(this);
        }
    }
}
