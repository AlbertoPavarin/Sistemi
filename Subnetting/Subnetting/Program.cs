﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] ip = new byte[4];
            byte[] sm = new byte[4];
            bool controllo;
            string s;
            IPv4 ipv4 = new IPv4();

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    Console.WriteLine($"Inserisci il {i + 1} otteto dell'ip");
                    s = Convert.ToString(Console.ReadLine());
                } while (!Byte.TryParse(s, out ip[i]));
            }
            ipv4.SetIp_address(ip);

            do
            {
                for (int i = 0; i < 4; i++)
                {
                    do
                    {
                        Console.WriteLine($"Inserisci il {i + 1} otteto della subnet mask");
                        s = Convert.ToString(Console.ReadLine());
                        controllo = Byte.TryParse(s, out sm[i]);
                    } while (!controllo || !ipv4.CheckSubOct(sm[i]));
                }
                ipv4.setSubnetMask(sm);
            } while (!ipv4.checkFullSub());

            Console.Clear();

            Console.WriteLine($"\n{ipv4.toString()}\n");
            Console.WriteLine($"Ip in bit: {ipv4.GetIP_addbool()}\n");
            Console.WriteLine($"Subnet mask in bit: {ipv4.GetCIDR()}\n");
            Console.WriteLine($"Indirizzo di rete: {String.Join(".",ipv4.GetNetworkAddress())}\n");
            Console.WriteLine($"Indirizzo di broadcast: {String.Join(".", ipv4.GetBroadcast())}\n");
            Console.WriteLine($"Wildcard mask: {String.Join(".", ipv4.GetWildcard())}\n");
            Console.WriteLine($"Numero totale degli host: {ipv4.GetTotalNumberHost()}\n");
            Console.WriteLine($"Numero degli host utilizzabili: {ipv4.GetNumberUsableHost()}\n");
            Console.WriteLine($"Range: {String.Join(".", ipv4.GetFirstHostIP())} - {String.Join(".", ipv4.GetLastHostIP())}\n");

            Console.ReadKey();
        }
    }
}
