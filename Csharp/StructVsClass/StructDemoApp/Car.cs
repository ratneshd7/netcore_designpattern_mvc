namespace StructDemoApp
{
    public struct Car
    {
        private string _brand;
        private string _model;
       

        public Car(string brand , string model)
        {
            _brand = brand;
            _model = model;
        }
        public void print()
        {
            System.Console.WriteLine(_brand);
            System.Console.WriteLine(_model);
        }
    }
}
