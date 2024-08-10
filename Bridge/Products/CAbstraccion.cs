namespace Bridge.Products
{
    public class CAbstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;


        public CAbstraccion(IBridge pImp, Dictionary<string, double> pProductos)
        {
            implementacion = pImp;
            productos = pProductos;
        }

        public CAbstraccion(int pTipo, Dictionary<string, double> pProductos) 
        {
            if (pTipo == 1)
                implementacion = new CImplementacion1();
            if (pTipo == 2)
                implementacion = new CImplementacion2();
            if (pTipo == 3)
                implementacion = new CImplementacion3();

            productos = pProductos;
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }

        public void ListarProductos()
        {
            implementacion.ListarProductos(productos);
        }

    }
}
