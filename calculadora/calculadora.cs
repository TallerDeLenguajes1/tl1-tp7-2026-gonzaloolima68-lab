namespace EspacioCalculadora
{
    class Calculadora
    {
        double dato;
        public double getdato()
        {
            return dato;
        }
        public void setdato(double valor)
        {
        dato=valor;
        }

        public void suma (double valor)
        {
            dato= dato + valor;
        }
        public void resta(double valor){
            dato=dato-valor;
        }

        public void multiplicar(double valor){
            dato= dato*valor;
        }
        public void dividir(double valor){
            dato=dato/valor;
        }

    }
}
