using System;
using System.IO;

namespace Facturacion
{
    public class Factura
    {
       #region Atributos
        private string nameP;
        private string nameC;
        private string description;
        private int quantity;
        private int price;
        private int nProduct;
        private int nFactura;
        private int value;
        private int total;
        private int totalValue;
        private int menu;
        private string x;
        private string y;
       #endregion

        public Factura()
        {}
        public void getFactura()
        {
            
                nFactura ++;
                // TextWriter archivo;
                //archivo = new StreamWriter("archivo.txt");
                Console.WriteLine("'x' para cerrar la factura");
                StreamWriter getFacturaFile = File.AppendText("facturaFile.txt");
                getFacturaFile.WriteLine("*************** Factura: #{0} **************",nFactura);
                getFacturaFile.WriteLine("Colmado Jose Luis");
                getFacturaFile.WriteLine("Tel: 809-456-4564 | Cel: 829-456-7841 ");
                
            do
            {
                nProduct ++;
                    
                    //obtener datos
                    Console.WriteLine("Nonbre del producto");
                    nameP = Console.ReadLine();
                    Console.WriteLine("descripcion del producto");
                    description = Console.ReadLine();
                    Console.WriteLine("precio del producto");
                    price = Console.Read();
                    Console.WriteLine("Cantidad");
                    quantity = Console.Read();

                    //calculo
                    //value = quantity * price;
                    //totalValue += value;
                     
                    //imprecion
                    getFacturaFile.WriteLine("------------------------------------------");
                    getFacturaFile.WriteLine("Producto: #{0}" ,nProduct);
                    getFacturaFile.WriteLine("Nombre: {0}" ,nameP);
                    getFacturaFile.WriteLine("Descripcion: {0}",description);
                    getFacturaFile.WriteLine("Valor: {0}", value);
                    getFacturaFile.WriteLine("Cantidad: {0}", quantity);
                    getFacturaFile.WriteLine("Total: {0}", total);           
                
                              
                    Console.WriteLine("'y' para continuar");
                    y = Console.ReadLine();
                    if(y=="y"){};         
            } 
            while(y=="y");
            {
                nProduct=0;
                DateTime thisDay = DateTime.Today;
                Console.WriteLine("Nonbre del cliente");
                nameC = Console.ReadLine();

                getFacturaFile.WriteLine("");
                getFacturaFile.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                getFacturaFile.WriteLine("Nonbre del cliente: {0}",nameC);
                getFacturaFile.WriteLine("Emicion de factura: ",thisDay.ToString());
                getFacturaFile.WriteLine("Valor total: ",totalValue);
                getFacturaFile.WriteLine("");
                getFacturaFile.WriteLine("******************************************");
                getFacturaFile.WriteLine("");
                getFacturaFile.Close();
                Console.Clear();
                
                postFactura(); 

                /*Console.WriteLine("Desea facturar nuevamente?  'y' o 'n'");   
                x = Console.ReadLine();
                if (x == "y"){getFactura();}
                else{Console.WriteLine("bye");}*/
            } 
        }

        public void postFactura()
        {
            TextReader readFactura;
            readFactura = new StreamReader("facturaFile.txt");
            Console.WriteLine(readFactura.ReadToEnd());
            readFactura.Close();
        }
    }
}








                /*
                using System.IO.StreamReader;
                
                StreamWriter fichero;
                fichero = File.CreateText("prueba.txt"); 
                
                fichero.WriteLine("esto es una línea");
                fichero.Write("fin de la cita.");
                fichero.Close();

                string linea;
                
                fichero = File.OpenText("prueba.txt");
                linea = fichero.ReadLine();
                fichero.Close();*/





            