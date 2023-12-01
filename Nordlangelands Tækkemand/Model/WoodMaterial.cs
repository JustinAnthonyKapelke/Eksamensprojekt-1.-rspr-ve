﻿using Nordlangelands_Tækkemand.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordlangelands_Tækkemand.Model
{
    //The class implements the IMaterial interface
    public class WoodMaterial : IMaterial
    {
        //Auto-Implemented Properties
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialImagePath { get; set; }
        public int MaterialStockCount { get; set; }
        public string MaterialType { get; set; }
        public int StorageID { get; set; }

        //Constructor
        public WoodMaterial(int materialID, string materialName, string materialDescription, string materialImagePath, int materialStockCount, string materialType, int storageID)
        {
            MaterialID = materialID;
            MaterialName = materialName;
            MaterialDescription = materialDescription;
            MaterialStockCount = materialStockCount;
            MaterialType = materialType;
            StorageID = storageID;
        }

        //Constructor Overload
        public WoodMaterial(string materialName, string materialDescription, string materialImagePath, int materialStockCount, string materialType, int storageID)
        {          
            MaterialName = materialName;
            MaterialDescription = materialDescription;
            MaterialStockCount = materialStockCount;
            MaterialType = materialType;
            StorageID = storageID;
        }
    }
}
