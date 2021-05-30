using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCollectionsApp
{
    class LineItem
    {
        private Guid _id;
        private string _name;
        private double _cost;
        private int _quantity;
        double totalcost;
        public LineItem(string name,double cost,int quantity)
        {
            _id = Guid.NewGuid();
            _name = name;
            _cost = cost;
            _quantity = quantity;
        }
        public Guid Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }
        public double CalTotalCost()
        {
            totalcost = _quantity * _cost;
            return totalcost;
        }

    }
}
