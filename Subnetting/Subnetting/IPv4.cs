using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    class IPv4
    {
        protected byte [] ipAddress;
        protected byte [] subnetMask;

        public IPv4()
        {
        }

        public byte[] GetIP_addr()
        {
            return this.ipAddress;
        }

        public string GetIP_addbool()      // ritorna l'ip in formato binario
        {
            string boolIP = "";
            foreach(byte oct in this.ipAddress)
            {
                boolIP += Convert.ToString(oct, 2).PadLeft(8, '0') + " ";
            }

            return boolIP;
        }

        public byte[] GetSubnetMask()
        {
            return this.subnetMask;
        }

        public bool CheckSubOct(byte octect)
        {
            string digits = Convert.ToString(octect, 2);
            if (digits.Length > 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (digits[i] == '0' && digits[i + 1] == '1')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool checkFullSub()
        {
            for (int i = 0; i < 3; i++)
            {
                if (this.subnetMask[i] < this.subnetMask[i+1])
                {
                    return false;
                }
            }

            return true;
        }

        public void SetIp_address(byte[] ip)
        {
            this.ipAddress = ip;
        }

        public void setSubnetMask(byte[] sm)
        {
            this.subnetMask = sm;
        }

        public byte[] GetNetworkAddress()
        {
            byte[] networkAddress = new byte[4];
            return networkAddress;
        }

        public byte[] GetBroadcast()
        {
            byte[] broadcastAddress = new byte[4];
            return broadcastAddress;
        }

        public int GetTotalNumberHost()
        {
            return 0;
        }

        public int GetNumberUsableHost()
        {
            return 0;
        }

        public string GetWildcard()
        {
            return "";
        }

        public string GetCIDR() // ritorna maschera in bit
        {
            string boolSub = "";
            foreach (byte oct in this.subnetMask)
            {
                boolSub += Convert.ToString(oct, 2).PadLeft(8, '0') + " ";
            }

            return boolSub;
        }

        public byte[] GetFirstHostIP()
        {
            byte[] firstIpAddress = new byte[4];
            return firstIpAddress;
        }

        public byte[] GetLastHostIP()
        {
            byte[] lastIpAddress = new byte[4];
            return lastIpAddress;
        }

        public string toString()
        {
            return $"Ip address: {this.ipAddress[0]}.{this.ipAddress[1]}.{this.ipAddress[2]}.{this.ipAddress[3]}\nSubnet Mask: {this.subnetMask[0]}.{this.subnetMask[1]}.{this.subnetMask[2]}.{this.subnetMask[3]}";
        }
    }
}
