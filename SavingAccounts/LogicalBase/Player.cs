using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccounts.LogicalBase
{
    public class Player
    {
        private string author;
        private string userName;
        private string password;
        private string categoryAcc;
        private string description;

        public string Author { get => author; set => author = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string CategoryAcc { get => categoryAcc; set => categoryAcc = value; }
        public string Description { get => description; set => description = value; }

        public Player()
        {
            this.author = null;
            this.userName = null;
            this.password = null;
            this.categoryAcc = null;
            this.description = null;
        }
        public Player(string author, string userName, string password, string categoryAcc, string description)
        {
            this.author = author;
            this.userName = userName;
            this.password = password;
            this.categoryAcc = categoryAcc;
            this.description = description;
        }
        public static Player GetPlayerFromBytes(byte[] data)
        {
            Player result = new Player();
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    result.Author = br.ReadString();
                    result.UserName = br.ReadString();
                    result.Password = br.ReadString();
                    result.CategoryAcc = br.ReadString();
                    result.Description = br.ReadString();
                }
            }
            return result;
        }
        public byte[] ToBytesArray(Player player)
        {
            using (MemoryStream ms = new MemoryStream()) 
            {
                using(BinaryWriter bw = new BinaryWriter(ms))
                {
                    bw.Write(player.Author);
                    bw.Write(player.UserName);
                    bw.Write(player.Password);
                    bw.Write(player.CategoryAcc);
                    bw.Write(player.Description);
                    bw.Flush();
                }
                ms.FlushAsync();
                return ms.ToArray();
            }
        }
    }
}
