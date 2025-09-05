namespace CalculatorApp.Models
{
    public class Calc

    {

        public string SerialNr { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Functions { get; set; }



        public Calc() { }



        public Calc(string serialNr, string make, string model,

          int functions)

        {

            SerialNr = serialNr;

            Make = make;

            Model = model;

            Functions = functions;

        }



        public override string ToString()

        {

            return $"{SerialNr}: {Make} {Model} with {Functions} functions";

        }

    }
}
