using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Example.SystemBlockExample
{
    public class SystemBlockBuilder:ISystemBlockBuilder
    {
        private SystemBlockClass product = new SystemBlockClass();
        public SystemBlockBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.product = new SystemBlockClass();
        }
        public SystemBlockClass GetProduct()
        {
            SystemBlockClass result = this.product;
            this.Reset();
            return result;
        }
        public void setBody()
        {
            product.Body = "DEEPCOOL MATREXX 55 MESH ADD-RGB 4F";
        }

        public void setCPU()
        {
            product.CPU = "AMD Ryzen 5 3600";
        }

        public void setHardDrive()
        {
            product.HardDrive = "1 ТБ Seagate 7200 BarraCuda";
        }

        public void setMotherBoard()
        {
            product.MotherBoard = "MSI Z490-A PRO";
        }

        public void setNetworkAdapter()
        {
            product.NetworkAdapter = "DEXP AT-UH001B";
        }

        public void setPSU()
        {
            product.PSU = "Cougar VTE600";
        }

        public void setRAM()
        {
            product.RAM = "AMD Radeon R7 Performance";
        }

        public void setSoundAdapter()
        {
            product.SoundAdapter = "Creative Sound BlasterX G6";
        }

        public void setSSD()
        {
            product.SSD = "Kingstone";
        }

        public void setVideoAdapter()
        {
            product.VideoAdapter = "Geforce GTX 1650";
        }
        

        
    }
}
