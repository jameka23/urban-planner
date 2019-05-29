using System;

namespace Planner
{
    // Define class here

    class Building
    {
        // C O N S T R U C T O R 
        public Building(string address){
            _address = address;
        }

        // P R I V A T E 
        private string _designer = "Jameka Echols";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }


        // P U B L I C
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume 
        {
            get
            {
                return Width * Depth * ( 3 * Stories);
            }
        }
        public string bldingAddress(){
            return _address;
        }
        public string designer(){
            return _designer;
        }
        public string owner(){
            return _owner;
        }
        public void Construct(){
            _dateConstructed = DateTime.Now;
        }
        public DateTime Constructed(){
            return _dateConstructed;
        }
        public void Purchase(string owner){
            _owner = owner;
        }
    }
}