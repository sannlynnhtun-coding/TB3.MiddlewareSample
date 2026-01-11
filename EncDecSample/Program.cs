// See https://aka.ms/new-console-template for more information
using Effortless.Net.Encryption;

Console.WriteLine("Hello, World!");

//byte[] key = Bytes.GenerateKey();
//byte[] iv = Bytes.GenerateIV();

//string _key = Convert.ToBase64String(key);
//string _iv = Convert.ToBase64String(iv);

//Console.WriteLine($"Key: {_key}");
//Console.WriteLine($"IV: {_iv}");

Console.WriteLine("zK3lnP4rY0BfCPGNu7CVJmd7k0xiVQK1Z0ahmUI+HD8=".Length);

byte[] key = Convert.FromBase64String("zK3lnP4rY0BfCPGNu7CVJmd7k0xiVQK1Z0ahmUI+HD8=");
byte[] iv = Convert.FromBase64String("P7ODJFGFiYKoKoCrVBhPmg==");

string encrypted = Strings.Encrypt("Secret", key, iv);
string decrypted = Strings.Decrypt(encrypted, key, iv);

Console.WriteLine("Encrypted: " + encrypted);
Console.WriteLine("Decrypted: " + decrypted);

Console.ReadLine();
