namespace Espaciocalculadora{
    public class Calculadora
    {
        private double dato;

        public double resultado
        {
            get
            {
                return dato;
            }
        }

        public void sumar(double num)
        {
            dato+=num;
        }

        public void restar(double num)
        {
            dato-=num;
        }

        public void multiplicar(double num)
        {
            dato*=num;
        }

        public void dividir(double num)
        {
            if (num != 0)
            {
                dato/=num;
            }
        }

        public void limpiar()
        {
            dato=0;
        }



    }
}
