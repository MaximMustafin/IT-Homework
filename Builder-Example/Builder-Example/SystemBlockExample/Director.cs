using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Example.SystemBlockExample
{
    public class Director
    {
        private ISystemBlockBuilder builder;

        public ISystemBlockBuilder Builder 
        {
            set
            {
                builder = value;
            } 
        }

        public void WithoutVideoCard()
        {
            builder.setBody();
            builder.setMotherBoard();
            builder.setPSU();
            builder.setCPU();
            builder.setRAM();
            builder.setNetworkAdapter();
            builder.setSoundAdapter();
            builder.setHardDrive();
            builder.setSSD();
        }

        public void WithoutRam()
        {
            builder.setBody();
            builder.setMotherBoard();
            builder.setPSU();
            builder.setCPU();
            builder.setVideoAdapter();
            builder.setNetworkAdapter();
            builder.setSoundAdapter();
            builder.setHardDrive();
            builder.setSSD();
        }
    }
}
