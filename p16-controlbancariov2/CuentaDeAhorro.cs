namespace p16_controlbancariov2
{
    public class CuentaDeAhorro : CuentaBancaria
    {
        public CuentaDeAhorro(float saldo, float interes): base(saldo){
            this.interes = interes;
        }
        public float interes { get; private set; }

        public void CalcularInteres(){
            saldo += (saldo*interes);
        }
    }
}