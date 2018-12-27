using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCracker
{
    class Program
    {
        class PasswordClass
        {
            public ObservableCollection<string> Passwords;
            public string Password;
            public string Hashed;

            public PasswordClass()
            {
                Passwords = new ObservableCollection<string>();
            }

            public string HashSHA256(string text)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                SHA256Managed hashstring = new SHA256Managed();
                byte[] hash = hashstring.ComputeHash(bytes);
                string hashString = string.Empty;
                foreach (byte x in hash)
                {
                    hashString += String.Format("{0:x2}", x);
                }
                return hashString;
            }

            public string CrackPassword(string pswd)
            {
                string[] ADC = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "G", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "\\", "]", "^", "_", "`", "{", "|", "}", "~" };
                var str = "";

                //get count of string
                var count = pswd.Length;

                for(int i = 0; i < count; i++)
                {
                    str = str + "a";
                }

                //loop through every possible variation
                for(int i = count; i > 0; i--)
                {
                    foreach(var j in ADC)
                    {
                        //change the value
                        str = str.Remove(i-1, 1);
                        str = str.Insert(i-1, j);

                        //compare hash
                        var hash = HashSHA256(str);
                        if(hash == Hashed)
                        {
                            return str;
                        }
                    }
                }

                return str;
            }            

            public string CountCrackedPasswords()
            {
                int count = 0;
                foreach(var i in Passwords)
                {
                    Hashed = HashSHA256(i);
                    var str = "";
                    str = CrackPassword(i);
                    if(str == "")
                    {
                        count++;
                    }
                }

                return count + "/" + Passwords.Count;
            }

            public void GeneratePasswords()
            {
                Passwords = new ObservableCollection<string>();

                Passwords.Add("Password");
                Passwords.Add("kaAVsCgN");
                Passwords.Add("VZYCDGks");
                Passwords.Add("saNrrgKw");
                Passwords.Add("QdsTyGqN");
                Passwords.Add("MtreynDU");
                Passwords.Add("dajUDKRB");
                Passwords.Add("CFrwSFmK");
                Passwords.Add("PLeXHNZR");
                Passwords.Add("ZeDWhGtK");
                Passwords.Add("txUYqrCF");
                Passwords.Add("^@r2aTDchT");
                Passwords.Add("#XF%8gRESD");
                Passwords.Add("^!~uj7MkPd");
                Passwords.Add("!M?Adh99>D");
                Passwords.Add("mR$w!6RHqB");
                Passwords.Add("$S+hE7DUG4");
                Passwords.Add("W&9~TW%E3k");
                Passwords.Add("N4&8!3ngE&");
                Passwords.Add("V#y&V856YE");
                Passwords.Add("PUh4&2XWBR");
                Passwords.Add("3pML~$KdYt");
                Passwords.Add("SZK4Ak#V?r");
                Passwords.Add("+8qnBBa#wb");
                Passwords.Add("E&@ZRKpS7a");
                Passwords.Add("9XJ8dH?D!J");
                Passwords.Add("9U3vJEDT>Q");
                Passwords.Add("PDW39+~QL3");
                Passwords.Add("@5UE?D9H>3");
                Passwords.Add("7ScCS@HKj+");
                Passwords.Add("cP?AYX?25D");
                Passwords.Add("duFGm^TMYS2$F7h~w6+N");
                Passwords.Add("e&ZX2bQ?ABc6mtE!JS%d");
                Passwords.Add("Qwv^es7J^3r2hntqU$!y");
                Passwords.Add("DUMW4fddn8ekU9$PU&KB");
                Passwords.Add("t+DnbEzYH>JdP9xr$~aG");
                Passwords.Add("w7c$a^&ptuFEq4xr?K2W");
                Passwords.Add("w7^gU!~Cjy7qT5NG98fh");
                Passwords.Add("%9P5vaBsnWGS>hU43j8c");
                Passwords.Add("vuRZmY>wdFGNLD>^h89C");
                Passwords.Add("qCKSndHD8tw^Nf%L29#$");
                Passwords.Add("&G%WHytUwDrG2mhde~49");
                Passwords.Add("6yX2^3Dz7hC@maFLdDCt");
                Passwords.Add("QdD#M9wzFV4+GY%@HACa");
                Passwords.Add("A^e?k$aX?Gwzh8ybdVsE");
                Passwords.Add("a&jRvbEcP^9TAtBSU#JF");
                Passwords.Add("e?u~R6bLJv+d32PDXAw^");
                Passwords.Add("TqUPW&Z@5>%8VL?hamt^");
                Passwords.Add("4&AB^gMtrdvx>kPAK5s8");
                Passwords.Add("y7+NU78#Dd~A%Q$a?5QX");
                Passwords.Add("L&x4gM>77Xdsc?QYDz~!");
                Passwords.Add("qA3TLvxCQCrV7+$^hjK&");
                Passwords.Add("74RJ>%K4kFGsj&@dHD5a");
                Passwords.Add("$?uNT@DVv3B2XQszvZCn");
                Passwords.Add("MxD$Q+4Sbmy@7KFU3q~H");
                Passwords.Add("sY?S7ftGHJdpKQ3@9ZZ6");
                Passwords.Add("DZJWB$d6wz53TMs&G779");
                Passwords.Add("NUsGd#3FP2yAebGfz9Tv");
                Passwords.Add("P4L?X?qJSD6b%EAV^B8t");
                Passwords.Add("$ur82k~d6M%wm?USDE9n");
                Passwords.Add("R%KwpGg74LrDYndytc%q");
                Passwords.Add("dAE5be%4n>vSP?pwQWq&kzhf65Uy8^HJLmah#K^r");
                Passwords.Add("%$t6EHvG@AwY3juTxeMHJb+D!7X#L?RmCys8U");
                Passwords.Add("d+4paNYvLCs8Gf>~kWXD#Kr3!E^TF9dcLwV6AUx2");
                Passwords.Add("g+WK^Ubu9cvknrRxfJ>8Nd7$Z3mYDG5Gs8taTE26");
                Passwords.Add("zfs?&q9MVEPRRxdrSAGa5?^@D6KDw5uHbFd%ncCN");
                Passwords.Add("AH?QKv3BX^B3n>g8dqDYz!ktuWjm5w~Nx2eGE9CP");
                Passwords.Add("xsvh4&Ycr6nw~FuhB3J+Qt>9K#@8G?jVp!d95DHS");
                Passwords.Add("LAK86$3t>D?~W^JeyQDVNRU5w#9axRr^b@4Czks4");
                Passwords.Add("^jrwtN@$8&BudzLyZTR%FJ#mA>7D9gNEqbEW8Dnd");
                Passwords.Add("2HhF9&VY7A2BrdDjNbcxJ^g$E!GPAk?z6XyQLeu5");
                Passwords.Add("23dqCEXDTVA3yt$@NF^f!Ubk#L4nejwuhJ8^Yz6s");
                Passwords.Add("RLYK2FT^8sZNA>Q+PZ6 XG4d!kc~BEmyH75v2");
                Passwords.Add("w@XEAHBGn2C?z$Qs9K>Ug%e6jk&3aT^uL!5ydqDh");
                Passwords.Add("dm#xPz$?Uc4q4hSXtDKM~kHbW>vZB^AYdsu?G@6F");
                Passwords.Add("Da%hu@CN3~+PdJ7zKQ9qx!S^Xgv5deV?ZzETbHFL");
                Passwords.Add("p5XKhDexNZV9s84#qTJH2>b5ky?d6~g^qWtJnaLv");
                Passwords.Add("$KTryhUXz5MVQwW9u7DBuk^2f@&p3xjAZ?m9dSFt");
                Passwords.Add("&4Sjm7gb+YGrWPvM~!sDHJCEPkNDpUTuFLZq&?hd");
                Passwords.Add("g%7ZyWM~qb!h5VLBA3Jtv+Z$DDXz48+6rNpDSeY2");
                Passwords.Add("XzvnyQ2S3+$dEnW^8VMbZU>GH~@DktNRFaJ#9AVu");
                Passwords.Add("Vb@Yh4T8p3qHFEUz>NQBkx&u^4cy@~Jne5wLA!DD");
                Passwords.Add("XmYW>AKe84DfwkG@Q95%DzpB>+ZbH7#njzNydvLx");
                Passwords.Add("^mHW%C+bw?4$kX5Vdc3QNYR>J68Ypt~S7#hLBfDF");
                Passwords.Add("5rda?KeC6m%?v#Y5jD7s$wb3MnQX^@&hkWXktZL8");
                Passwords.Add("#S^3Y9fZ7XRUD&3pPhQ@aBtWdMvbnwr#xgsq4dEj");
                Passwords.Add("WDd#dHDbQT%w542cGM7xmEgYvA>~pj+r$~QSa2?@");
                Passwords.Add("9dTdCQA78N#awRBDb^5qkcvH@~PDZE>%thM7GS6z");
                Passwords.Add("D+gX~hrz5mD#!!^Q5KfZ$GRLC7@xMJbAjuE8awy2");
                Passwords.Add("~rXpDk?8mB&T4zn64W>7?$ZAReqKvM@QL!NJ#%Yw");
                Passwords.Add("w#G&+zs9m5!e6hMrJfbcZVgNBnxku2DU$yqTWYS>");
                Passwords.Add("K>wjzV!RbguBvd9caYH6JD3^XemtyG?WQTf4~s3N+pD7v5kP@CnSD#h?&2$rxAZ");
                Passwords.Add("yLVep+bq@&hn$@D47acwES%ZW2fJ3!NvBY^dTUSuSFX9xtk58jD~A9CmRg#>6H?");
                Passwords.Add("5&p#3j8F~wsU@6DSR8gH$hb4yfKM4>n+tXd2ACum$7DxZTde!%?qUNQEWz9YJBG");
                Passwords.Add("chE?Lu6yjbk!+GW2TKJZ7~qU$%^MVBRQ&NmxVXfw~C@Bap8dgHDA3sdYDn9#5z4");
                Passwords.Add("#EKg6jM+7tdXVfrdcR!q$kN%YA$TGrbH&uh9peQ5z36myPnDS@W~Rx8JZ^s>L4C");
                Passwords.Add("63vXD%46d!?qmNuYadKtGXWM~Hj$spnc8%y>eVA7J^wgx@bzFfP5#CUD$&R+ESh");
                Passwords.Add("VkbuWF>qnUg@^%dP&Ch+967E!tj8mpMJazr4w%ZBNALKd#2y3X$cAS6DvxHD5fC");
                Passwords.Add(">&vE7d8Ft4ASrK?UG3%~N~cDehZPmLskD6YgpS@njHJQBbdaw6V!fM+D$q2^yR#");
                Passwords.Add("mND3ZAgcH+x>K%hdTe77kKn~XJMUCFb2Rf#4pL!@6qD5&u$V^9GQPwvWyaj7rBY");
                Passwords.Add("6H9ANU@B4wb#RNXrc+DvCG8SC&pVduFL!?zkK~#jsnyhM2^JqPEmW3ax7TQe$Zg");
            }
        }
        static void Main(string[] args)
        {
            var entry = "";
            var pswd = "";

            var PW = new PasswordClass();

            Console.WriteLine("Welcome to Password Cracker, made by Matt Dean as a side project for educational purposes only.");
            do {
                Console.Write("Do you want to generate 100 passwords? (Y/N): ");
                entry = Console.ReadLine();
                if (entry.ToUpper() == "Y")
                {
                    PW.GeneratePasswords();
                }
                else if (entry.ToUpper() == "N")
                {
                    //get user to input a password
                    Console.Clear();
                    Console.Write("Please enter a password to use: ");
                    pswd = Console.ReadLine();
                    PW.Password = PW.HashSHA256(pswd);
                }
            }
            while (entry.ToUpper() != "Y" && entry.ToUpper() != "N");

            Console.Clear();
            Console.WriteLine("Cracked " + PW.CountCrackedPasswords() + " passwords.");

            Console.ReadLine();
        }
    }
}
