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
        //INotifyPropertyChanged EventHandler
        public event PropertyChangedEventHandler? PropertyChanged;

        // INotifyPropertyChanged Method
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }        
        
        //Fields
        public ThatchingRepository thatchingRepo;
        private int _materialID;
        private string _materialName;
        private string _materialDescription;
        private string _materialType;
        private string _materialImagePath;
        private int _materialStockCount;
        private int _materialTypeID;
        private int _storageID;

        //Properties
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
        public ThatchingViewModel()
        {
            thatchingRepo = new ThatchingRepository(CreateDelegate, InitializeDelegate);
        }

        //Constructor overload
        public ThatchingViewModel(ThatchingMaterial material)
        {
            // Initialize properties using the ThatchingMaterial object
            MaterialID = material.MaterialID;
            MaterialName = material.MaterialName;
            MaterialDescription = material.MaterialDescription;
            MaterialImagePath = material.MaterialImagePath;
            MaterialStockCount = material.MaterialStockCount;
            MaterialType = material.MaterialType;
            MaterialTypeID = material.MaterialTypeID;
            StorageID = material.StorageID;
            thatchingRepo = new ThatchingRepository(CreateDelegate, InitializeDelegate);
        }        

        //Delegates 
        public ThatchingMaterial CreateDelegate(string materialName, string materialDescription, string materialImagePath, int materialStockCount, int materialTypeID, int storageID)
        {
            return new ThatchingMaterial(materialName, materialDescription, materialImagePath, materialStockCount, materialTypeID, storageID);
        }

        public ThatchingMaterial InitializeDelegate(int materialID, string materialName, string materialDescription, string materialImagePath, int materialStockCount, string materialType, int storageID)
        {
            return new ThatchingMaterial(materialID, materialName, materialDescription, materialImagePath, materialStockCount, materialType, storageID);
        }

        //Methods
        public ThatchingMaterial ReadLastAddedMaterialFromDatabase()
        { 
            return thatchingRepo.ReadLastAddedMaterialFromDatabase();  
        }
        
        public ThatchingMaterial ReadMaterialByIDFromDatabase(int materialID)
        {
            return thatchingRepo.ReadMaterialByIDFromDatabase(materialID);
        }      
        
        public string ReadLogTextFromDatabase()
        {
            return thatchingRepo.ReadLogTextFromDatabase();
        }
             
        
        public void CreateMaterialInDatabase(string materialName, string materialDescription, int materialStockCount, int materialTypeID, int storageID)
        {
            thatchingRepo.CreateMaterialInDatabase(materialName, materialDescription, materialStockCount, materialTypeID, storageID);
        }

        public void DeleteMaterialFromDatabaseByID(int materialID)
        { 
            thatchingRepo.DeleteMaterialFromDatabaseByID(materialID);
        }
        public void InitializeMaterials()
        {
            thatchingRepo.InitializeMaterials();
        }

        public void UpdateMaterial(int materialID, string materialName, string materialDescription, int materialTypeID, int materialStockCount, int storageID)
        {
            thatchingRepo.UpdateMaterialInDatabase(materialID, materialName, materialDescription, materialTypeID, materialStockCount, storageID);
            thatchingRepo.ClearMaterialsInRepo();
        }
        
        public void UpdateStockCountInDatabase(int materialID, int newMaterialAmount)
        {
            thatchingRepo.UpdateStockCountInDatabase(materialID, newMaterialAmount);
        }
    }
}
