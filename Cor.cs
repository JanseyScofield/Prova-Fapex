using System.Globalization;
using Prova.CoresPrimarias;

namespace Prova {
    public class Cor {
        public Red Red { get; set; }
        public Green Green { get; set; }
        public Blue Blue { get ; set; }
        public Preto Preto { get; set; } 
        public Branco Branco { get; set; }


        public Cor(Red red, Green green, Blue blue) {
            Validacao(red, green, blue);

        }

        public Cor(Red red) {
            Validacao(red, new Green(0), new Blue(0));
        }

        public Cor(Blue blue) {
            Validacao(new Red(0), new Green(0), blue);
        }

        public Cor(Green green) {
            Validacao(new Red(0), green, new Blue(0));
        }

        public Cor() {
            Red = new Red(0);
            Green = new Green(0);
            Blue = new Blue(0);
        }

        public void Validacao(Red red, Green green, Blue blue) {
            int redInt = red.value;
            int greenInt = green.value;
            int blueInt = blue.value;
            while (true) {
                if (redInt > 255 || greenInt > 255 || blueInt > 255) {
                    Console.WriteLine("Valores maiores do que o permitido. ");
                    Console.WriteLine("Digite novamente o valor das cores: ");
                    Console.Write("Red: ");
                    redInt = int.Parse(Console.ReadLine());
                    Console.Write("Green: ");
                    greenInt = int.Parse(Console.ReadLine());
                    Console.Write("Blue: ");
                    blueInt = int.Parse(Console.ReadLine());
                } else if (redInt < 0 || greenInt < 0 || blueInt < 0) {
                    Console.WriteLine("Valores menores que o esperado.");
                    Console.WriteLine("Digite novamente o valor das cores: ");
                    Console.Write("Red: ");
                    redInt = int.Parse(Console.ReadLine());
                    Console.Write("Green: ");
                    greenInt = int.Parse(Console.ReadLine());
                    Console.Write("Blue: ");
                    blueInt = int.Parse(Console.ReadLine());
                } else {
                    Red = new Red(redInt);
                    Green = new Green(greenInt);
                    Blue = new Blue(blueInt);
                    break;
                }
            }
        }
        public int Luminosidade() {
            return (int)(Red.value * 0.3 + Green.value * 0.59 + Blue.value * 0.11);
        }

        public Cor GetCopia() {
            var copiaCor = new Cor(this.Red, this.Green, this.Blue);
            return copiaCor;
        }

        public static bool CheckCor(Cor cor1, Cor cor2) {
            if (cor1.Red == cor2.Red && cor1.Green == cor2.Green && cor1.Blue == cor2.Blue) 
                return true;
            else 
                return false;
        }

        public static string CodigoCor(Cor cor) { 

            string redHex = cor.Red.value.ToString("X2");
            string grennHex = cor.Green.value.ToString("X2");
            string blueHex = cor.Blue.value.ToString("X2");
            return "#" + redHex + grennHex + blueHex;
        }

        public static Cor CinzaCor(Cor cor) {

            Cor corCinza = new Cor();

            int redInt = 0;
            int greenInt = 0;
            int blueInt = 0 ;

            while (cor.Luminosidade() != corCinza.Luminosidade()) {
                redInt++;
                greenInt++;
                blueInt++;
                corCinza = new Cor(new Red(redInt), new Green(greenInt), new Blue(blueInt));

            }
            return corCinza;

        }

        public static Cor Clarear(Cor cor, double porcent) {
            int redInt = (int)(cor.Red.value + cor.Red.value*porcent);
            int greenInt = (int)(cor.Green.value + cor.Green.value * porcent);
            int blueInt = (int)(cor.Blue.value + cor.Blue.value * porcent);
             
           Cor corClareada = new Cor(new Red(redInt), new Green(greenInt), new Blue(blueInt));
            return corClareada;
        }

        public static Cor Escurecer(Cor cor, double porcent) {
            int redInt = (int)(cor.Red.value - cor.Red.value * porcent);
            int greenInt = (int)(cor.Green.value - cor.Green.value * porcent);
            int blueInt = (int)(cor.Blue.value - cor.Blue.value * porcent);

            Cor corEscurecida = new Cor(new Red(redInt), new Green(greenInt), new Blue(blueInt));
            return corEscurecida;
        }

        public static Cor TipoRGB(string hex) {
            int[] arrayNum = new int[3];
            int iCont = 0;
            int jCont = 0;
            string numString = "";
            foreach(var item in hex) {
                iCont++;
                numString += item; 
                if(iCont%2 == 0) {
                    arrayNum[jCont] = int.Parse(numString, NumberStyles.HexNumber);
                    numString = ""; 
                    jCont++;
                }
            }
            int red = arrayNum[0];
            int green = arrayNum[1];
            int blue = arrayNum[2];

            Cor corRGB = new Cor(new Red(red), new Green(green), new Blue(blue));

            return corRGB;
        }
        public override string ToString() {
            return "Red " + Red.value +  ", Green " + Green.value + ", Blue " + Blue.value + ". Luminosidade: " + Luminosidade() + ".";
        }


    }
}
