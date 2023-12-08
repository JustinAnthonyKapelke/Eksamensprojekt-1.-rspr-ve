﻿using Nordlangelands_Tækkemand.Interfaces;
using Nordlangelands_Tækkemand.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nordlangelands_Tækkemand.ViewModel
{
    public class ThatchingViewModel : INotifyPropertyChanged, IMaterialViewModel
    {
        public ThatchingRepository thatchingRepo;

        public event PropertyChangedEventHandler? PropertyChanged;

        // INotifyPropertyChanged Method
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }        

        private int _materialID;
        public int MaterialID
        {
            get { return _materialID; }
            set
            {
                if (_materialID != value)
                {
                    _materialID = value;
                    OnPropertyChanged(nameof(MaterialID));

                }
            }
        }


        private string _materialName;
        public string MaterialName
        {
            get { return _materialName; }
            set
            {
                if (_materialName != value)
                {
                    _materialName = value;
                    OnPropertyChanged(nameof(MaterialName));

                }
            }
        }

        private string _materialDescription;
        public string MaterialDescription
        {
            get { return _materialDescription; }
            set
            {
                if (_materialDescription != value)
                {
                    _materialDescription = value;
                    OnPropertyChanged(nameof(MaterialDescription));

                }
            }
        }

        private string _materialType;
        public string MaterialType
        {
            get { return _materialType; }
            set
            {
                if (_materialType != value)
                {
                    _materialType = value;
                    OnPropertyChanged(nameof(MaterialType));

                }
            }
        }


        
        private string _materialImagePath;
        public string MaterialImagePath
        {
            get { return _materialImagePath; }
            set
            {
                if (_materialImagePath != value)
                {
                    _materialImagePath = value;
                    OnPropertyChanged(nameof(MaterialImagePath));

                }
            }
        }

        private int _materialStockCount;
        public int MaterialStockCount
        {
            get { return _materialStockCount; }
            set
            {
                if (_materialStockCount != value)
                {
                    _materialStockCount = value;
                    OnPropertyChanged(nameof(MaterialStockCount));

                }
            }
        }

        private int _materialTypeID;
        public int MaterialTypeID
        {
            get { return _materialTypeID; }
            set
            {
                if (_materialTypeID != value)
                {
                    _materialTypeID = value;
                    OnPropertyChanged(nameof(MaterialTypeID));

                }
            }
        }


        private int _storageID;
        public int StorageID
        {
            get { return _storageID; }
            set
            {
                if (_storageID != value)
                {
                    _storageID = value;
                    OnPropertyChanged(nameof(StorageID));

                }
            }
        }


        //Constructor
        public ThatchingViewModel(ThatchingMaterial material)
        {
            // Initialize properties using the ThatchingMaterial object
            MaterialID= material.MaterialID;
            MaterialName = material.MaterialName;
            MaterialDescription = material.MaterialDescription;
            MaterialImagePath = material.MaterialImagePath;
            MaterialStockCount = material.MaterialStockCount;
            MaterialType = material.MaterialType;
            MaterialTypeID = material.MaterialTypeID;
            StorageID = material.StorageID;

            thatchingRepo = new ThatchingRepository(CreateDelegate, InitializeDelegate);
        }

        //Constructor Overload
        public ThatchingViewModel()
        {         
            thatchingRepo = new ThatchingRepository(CreateDelegate, InitializeDelegate);
        }

        public ThatchingMaterial CreateDelegate(string materialName, string materialDescription, string materialImagePath, int materialStockCount, int materialTypeID, int storageID)
        {
            return new ThatchingMaterial(materialName, materialDescription, materialImagePath, materialStockCount, materialTypeID, storageID);
        }

        public ThatchingMaterial InitializeDelegate(int materialID, string materialName, string materialDescription, string materialImagePath, int materialStockCount, string materialType, int storageID)
        {
            return new ThatchingMaterial(materialID, materialName, materialDescription, materialImagePath, materialStockCount, materialType, storageID);
        }

        //Method
        public void CreateMaterial(string materialName, string materialDescription, int materialStockCount, int materialTypeID, int storageID)
        {           
            thatchingRepo.CreateMaterialInDatabase(materialName, materialDescription, materialStockCount, materialTypeID, storageID);
            thatchingRepo.InitializeMaterials();
        }

        public void DeleteMaterial(int materialID)
        {
            thatchingRepo.DeleteMaterialFromDatabase(materialID);
            thatchingRepo.InitializeMaterials();
        }
    }
}
