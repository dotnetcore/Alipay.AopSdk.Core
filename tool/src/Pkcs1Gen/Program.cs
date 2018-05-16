using System;
using System.IO;
using System.Text;
using XC.Framework.Security.RSAUtil;

namespace Pkcs1Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Environment.CurrentDirectory;
            if (args.Length != 0)
            {
                filePath = args[0];
            }
            var keyList = RsaKeyGenerator.Pkcs1Key(2048,false);
            var privateKey = keyList[0];
            var publicKey = keyList[1];

            Console.WriteLine("生成成功！编码UTF-8");
            Console.WriteLine("私钥：");
            Console.WriteLine(privateKey);
            Console.WriteLine("公钥：");
            Console.WriteLine(publicKey);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            File.WriteAllText(Path.Combine(filePath, "私钥.txt"),privateKey,Encoding.UTF8);
            File.WriteAllText(Path.Combine(filePath, "公钥.txt"), publicKey, Encoding.UTF8);
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
    }
}
