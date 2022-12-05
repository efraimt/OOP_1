namespace SwapLogic
{

    public class SwapClass
    {

        public static string Description { get; set; }
       

        public static void Swap( object a, object b)
        {
            object c = a;
            a = b;
            b = c;
        }

    }
}