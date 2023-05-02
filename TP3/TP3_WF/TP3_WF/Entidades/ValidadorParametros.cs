namespace TP3_WF.Entidades
{
    class ValidadorParametros
    {
        public ValidadorParametros() { }

        public bool validarSuperiorACero(int n)
        {
            // Valida que el parametro(int) ingresado sea superior a 0
            return n > 0;
        }

        public bool validarDesde(int cantExp, int desde)
        {
            // Valida que el valor desde(nroExp) no supere la cantidad de experimentos.
            if(desde < cantExp) return false; 
            return true;
        }
        
        public bool validarCant(int cantExp, int desde, int cant)
        {
            // Valida que la cantidad sumada al valor desde(NroExp) no supere la cantidad de experimentos.
            if(cant + desde < cantExp) return false;
            return true;
        }
    }
}
