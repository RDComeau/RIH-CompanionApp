﻿using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using Server.Models.VersionOne;
using Server.Models.VersionOne.Devout;
using Server.Models.VersionOne.Leaders;
using Server.Models.VersionOne.Minions.GreaterDemons;
using Server.Models.VersionOne.Minions.LesserDemons;
using Server.Models.VersionOne.Minions.SuperiorDemons;
using Server.Services.VersionOne;
using Server.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Server.Models.Enums.Flight;

namespace Server.Test.Services.VersionOne
{
    [TestFixture]
    public class UnitsInformationServiceTest
    {
        private IUnitsInformationService _unitsInformationService;

        [SetUp]
        public void setup()
        {
            _unitsInformationService = new UnitsInformationService();
        }

        [Test]
        public void GetWarriorInformation_ShouldReturnWarriorInformation_WhenInvoked()
        {
            //Arrange
            Warrior expectedUnit = new Warrior()
            {
                cost = 0,
                move = 6,
                life = 15,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            Warrior acutualUnit = _unitsInformationService.GetWarriorInformation();

            //Asert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, acutualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSchemerInformation_ShouldReturnSchemerInformation_WhenInvoked()
        {
            //Arrange
            Schemer expectedUnit = new Schemer()
            {
                cost = 0,
                move = 8,
                life = 11,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            Schemer actualUnit = _unitsInformationService.GetSchemerInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetZealotInformation_ShouldReturnZealotInformation_WhenInvoked()
        {
            //Arrange
            Zealot expectedUnit = new Zealot()
            {
                cost = 0,
                move = 7,
                life = 13,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            Zealot actualUnit = _unitsInformationService.GetZealotInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllLeadersInformation_ShourldReturnAllLeadersInformation_WhenInvoked()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                cost = 0,
                move = 6,
                life = 15,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Schemer schemer = new Schemer()
            {
                cost = 0,
                move = 8,
                life = 11,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Zealot zealot = new Zealot()
            {
                cost = 0,
                move = 7,
                life = 13,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            List<BaseUnit> expectedUnits = new List<BaseUnit>()
            {
                warrior,
                schemer,
                zealot
            };

            //Act
            List<BaseUnit> actualUnits = _unitsInformationService.GetAllLeadersInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnits, actualUnits);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetLordOfThePitInformation_ShouldReturnLordOfThePitInformation_WhenInvoked()
        {
            //Arrange
            LordOfThePit expectedUnit = new LordOfThePit()
            {
                cost = 0,
                move = 8,
                life = 12,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            //Act
            LordOfThePit actualUnit = _unitsInformationService.GetLordOfThePitInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetExecutionerInformation_ShouldRetunExecutionerInformation_WhenInvoked()
        {
            //Arrange
            Executioner expectedUnit = new Executioner()
            {
                cost = 0,
                move = 5,
                life = 12,
                combat = 8,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            Executioner actualUnit = _unitsInformationService.GetExecutionerInformatioin();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetMadnessDeamonInformation_ShouldReturnMadnessDeamonInformation_WhenInvoked()
        {
            //Arrange
            MadnessDemon expectedUnit = new MadnessDemon()
            {
                cost = 0,
                move = 5,
                life = 11,
                combat = 3,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            MadnessDemon actualUnit = _unitsInformationService.GetMadnessDemonInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetTallymanInformation_ShouldRetunTallymanInformation_WhenInvoked()
        {
            //Arrange
            Tallyman expectedUnit = new Tallyman()
            {
                cost = 0,
                move = 4,
                life = 11,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            Tallyman actualUnit = _unitsInformationService.GetTallymanInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSuccubusInformation_ShouldReturnSuccubusInformation_WhenInvoked()
        {
            //Arrange
            Succubus expectedUnit = new Succubus()
            {
                cost = 0,
                move = 6,
                life = 9,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            //Act
            Succubus actualUnit = _unitsInformationService.GetSuccubusInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetVoidDemonInformation_ShouldReturnVoidDemonInformation_WhenInvoked()
        {
            //Arrange
            VoidDemon expectedUnit = new VoidDemon()
            {
                cost = 0,
                move = 8,
                life = 10,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            VoidDemon actualUnit = _unitsInformationService.GetVoidDemonInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllDevoutsInformation_ShouldRetuanAllDevoutsInformation_WhenInvoked()
        {
            //Arrange
            LordOfThePit lordOfThePit = new LordOfThePit()
            {
                cost = 0,
                move = 8,
                life = 12,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            Executioner executioner = new Executioner()
            {
                cost = 0,
                move = 5,
                life = 12,
                combat = 8,
                fly = Convert.ToBoolean(CanFly.No)
            };

            MadnessDemon madnessDemon = new MadnessDemon()
            {
                cost = 0,
                move = 5,
                life = 11,
                combat = 3,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Tallyman tallyman = new Tallyman()
            {
                cost = 0,
                move = 4,
                life = 11,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Succubus succubus = new Succubus()
            {
                cost = 0,
                move = 6,
                life = 9,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            VoidDemon voidDemon = new VoidDemon()
            {
                cost = 0,
                move = 8,
                life = 10,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            List<BaseUnit> expectedUnits = new List<BaseUnit>()
            {
                lordOfThePit,
                executioner,
                madnessDemon,
                tallyman,
                succubus,
                voidDemon
            };

            //Act
            List<BaseUnit> actualUnits = _unitsInformationService.GetAllDevoutsInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnits, actualUnits);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSlaughterFiendInformation_ShouldReturnSlaughterFiendInformation_WhenInvoked()
        {
            //Arrange
            SlaughterFiend expectedUnit = new SlaughterFiend()
            {
                cost = 21,
                move = 5,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            SlaughterFiend actualUnit = _unitsInformationService.GetSlaughterFiendInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetMephitInformation_ShouldReturnMephitInformation_WhenInvoked()
        {
            //Arrange
            Mephit expectedUnit = new Mephit()
            {
                cost = 16,
                move = 9,
                life = 7,
                combat = 3,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            //Act
            Mephit actualUnit = _unitsInformationService.GetMephitInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetTentacleBeastInformation_ShouldReturnTentacleBeastInformation_WhenInvoked()
        {
            //Arrange
            TentacleBeast expectedUnit = new TentacleBeast()
            {
                cost = 21,
                move = 8,
                life = 9,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            TentacleBeast actualUnit = _unitsInformationService.GetTentacleBeastInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetArmoredDemonInformation_ShouldReturnArmoredDemonInformation_WhenInvoked()
        {
            //Arrange
            ArmoredDemon expectedUnit = new ArmoredDemon()
            {
                cost = 22,
                move = 4,
                life = 13,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            ArmoredDemon actualUnit = _unitsInformationService.GetArmoredDemonInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSpinedDemonInformation_ShouldReturnSpinedDemonInformation_WhenInvoked()
        {
            //Arrange
            SpinedDemon expectedUnit = new SpinedDemon()
            {
                cost = 19,
                move = 6,
                life = 7,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            SpinedDemon actualUnit = _unitsInformationService.GetSpinedDemonInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetCorpulentDemonInformation_ShouldReturnCorpulentDemonInformation_WhenInvoked()
        {
            //Arrange
            CorpulentDemon expectedUnit = new CorpulentDemon()
            {
                cost = 17,
                move = 4,
                life = 15,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            CorpulentDemon actualUnit = _unitsInformationService.GetCorpulentDemonInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllLesserDemonsInformation_ShouldReturnAllLesserDemonsInformation_WhenInvoked()
        {
            //Arrange
            SlaughterFiend slaughterFiend = new SlaughterFiend()
            {
                cost = 21,
                move = 5,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Mephit mephit = new Mephit()
            {
                cost = 16,
                move = 9,
                life = 7,
                combat = 3,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            TentacleBeast tentacleBeast = new TentacleBeast()
            {
                cost = 21,
                move = 8,
                life = 9,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.No)
            };

            ArmoredDemon armoredDemon = new ArmoredDemon()
            {
                cost = 22,
                move = 4,
                life = 13,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            SpinedDemon spinedDemon = new SpinedDemon()
            {
                cost = 19,
                move = 6,
                life = 7,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            CorpulentDemon corpulentDemon = new CorpulentDemon()
            {
                cost = 17,
                move = 4,
                life = 15,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.No)
            };

            List<BaseUnit> expectedUnits = new List<BaseUnit>()
            {
                slaughterFiend,
                mephit,
                tentacleBeast,
                armoredDemon,
                spinedDemon,
                corpulentDemon
            };

            //Act
            List<BaseUnit> actualUnits = _unitsInformationService.GetAllLesserDemonsInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnits, actualUnits);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetTortureMasterInformation_ShouldReturnTortureMasterInformation_WhenInvoked()
        {
            //Arrange
            TortureMaster expectedUnit = new TortureMaster()
            {
                cost = 27,
                move = 6,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            TortureMaster actualUnit = _unitsInformationService.GetTortureMasterInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSerpentKnightInformation_ShouldReturnSerpentKnightInformation_WhenInvoked()
        {
            //Arrange
            SerpentKnight expectedUnit = new SerpentKnight()
            {
                cost = 26,
                move = 7,
                life = 11,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            SerpentKnight actualUnit = _unitsInformationService.GetSerpentKnightInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetMarquessDWinterInformation_ShouldReturnMarquessDWinterInformation_WhenInvoked()
        {
            //Arrange
            MarquessDWinter expectedUnit = new MarquessDWinter()
            {
                cost = 24,
                move = 4,
                life = 11,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            MarquessDWinter actualUnit = _unitsInformationService.GetMarquessDWinterInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllGreaterDemonsInformation_ShouldReturnAllGreaterDemonsInformation_WhenInvoked()
        {
            //Arrange
            TortureMaster tortureMaster = new TortureMaster()
            {
                cost = 27,
                move = 6,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            SerpentKnight serpentKnight = new SerpentKnight()
            {
                cost = 26,
                move = 7,
                life = 11,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            MarquessDWinter marquessDWinter = new MarquessDWinter()
            {
                cost = 24,
                move = 4,
                life = 11,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            List<BaseUnit> expectedUnits = new List<BaseUnit>()
            {
                tortureMaster,
                serpentKnight,
                marquessDWinter
            };

            //Act
            List<BaseUnit> actualUnits = _unitsInformationService.GetAllGreaterDemonsInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnits, actualUnits);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetShadowKingInformation_ShouldReturnShadowKingInformation_WhenInvoked()
        {
            //Arrange
            ShadowKing expectedUnit = new ShadowKing()
            {
                cost = 33,
                move = 7,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            //Act
            ShadowKing actualUnit = _unitsInformationService.GetShadowKingInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetLordOfFlameInformation_ShouldReturnLordOfFlameInformation_WhenInvoked()
        {
            //Arrange
            LordOfFlame expectedUnit = new LordOfFlame()
            {
                cost = 36,
                move = 8,
                life = 11,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            //Act
            LordOfFlame actualUnit = _unitsInformationService.GetLordOfFlameInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetVenomQueenInformation_ShouldReturnVenomQueenInformation_WhenInvoked()
        {
            //Arrange
            VenomQueen expectedUnit = new VenomQueen()
            {
                cost = 31,
                move = 5,
                life = 13,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            //Act
            VenomQueen actualUnit = _unitsInformationService.GetVenomQueenInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnit, actualUnit);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllSuperiorDemonsInformation_ShouldReturnAllSuperiorDemonsInformation_WhenInvoked()
        {
            //Arrange
            ShadowKing shadowKing = new ShadowKing()
            {
                cost = 33,
                move = 7,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            LordOfFlame lordOfFlame = new LordOfFlame()
            {
                cost = 36,
                move = 8,
                life = 11,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            VenomQueen venomQueen = new VenomQueen()
            {
                cost = 31,
                move = 5,
                life = 13,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            List<BaseUnit> expectedUnits = new List<BaseUnit>()
            {
                shadowKing,
                lordOfFlame,
                venomQueen
            };

            //Act
            List<BaseUnit> actualUnits = _unitsInformationService.GetAllSuperiorDemons();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnits, actualUnits);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllUnitsInformation_ShouldReturnAllUnitsInformation_WhenInvoked()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                cost = 0,
                move = 6,
                life = 15,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Schemer schemer = new Schemer()
            {
                cost = 0,
                move = 8,
                life = 11,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Zealot zealot = new Zealot()
            {
                cost = 0,
                move = 7,
                life = 13,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            LordOfThePit lordOfThePit = new LordOfThePit()
            {
                cost = 0,
                move = 8,
                life = 12,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            Executioner executioner = new Executioner()
            {
                cost = 0,
                move = 5,
                life = 12,
                combat = 8,
                fly = Convert.ToBoolean(CanFly.No)
            };

            MadnessDemon madnessDemon = new MadnessDemon()
            {
                cost = 0,
                move = 5,
                life = 11,
                combat = 3,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Tallyman tallyman = new Tallyman()
            {
                cost = 0,
                move = 4,
                life = 11,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Succubus succubus = new Succubus()
            {
                cost = 0,
                move = 6,
                life = 9,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            VoidDemon voidDemon = new VoidDemon()
            {
                cost = 0,
                move = 8,
                life = 10,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            SlaughterFiend slaughterFiend = new SlaughterFiend()
            {
                cost = 21,
                move = 5,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            Mephit mephit = new Mephit()
            {
                cost = 16,
                move = 9,
                life = 7,
                combat = 3,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            TentacleBeast tentacleBeast = new TentacleBeast()
            {
                cost = 21,
                move = 8,
                life = 9,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.No)
            };

            ArmoredDemon armoredDemon = new ArmoredDemon()
            {
                cost = 22,
                move = 4,
                life = 13,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            SpinedDemon spinedDemon = new SpinedDemon()
            {
                cost = 19,
                move = 6,
                life = 7,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            CorpulentDemon corpulentDemon = new CorpulentDemon()
            {
                cost = 17,
                move = 4,
                life = 15,
                combat = 4,
                fly = Convert.ToBoolean(CanFly.No)
            };

            TortureMaster tortureMaster = new TortureMaster()
            {
                cost = 27,
                move = 6,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            SerpentKnight serpentKnight = new SerpentKnight()
            {
                cost = 26,
                move = 7,
                life = 11,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.No)
            };

            MarquessDWinter marquessDWinter = new MarquessDWinter()
            {
                cost = 24,
                move = 4,
                life = 11,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.No)
            };

            ShadowKing shadowKing = new ShadowKing()
            {
                cost = 33,
                move = 7,
                life = 10,
                combat = 6,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            LordOfFlame lordOfFlame = new LordOfFlame()
            {
                cost = 36,
                move = 8,
                life = 11,
                combat = 7,
                fly = Convert.ToBoolean(CanFly.Yes)
            };

            VenomQueen venomQueen = new VenomQueen()
            {
                cost = 31,
                move = 5,
                life = 13,
                combat = 5,
                fly = Convert.ToBoolean(CanFly.No)
            };

            List<BaseUnit> expectedUnits = new List<BaseUnit>()
            {
                warrior,
                schemer,
                zealot,
                lordOfThePit,
                executioner,
                madnessDemon,
                tallyman,
                succubus,
                voidDemon,
                slaughterFiend,
                mephit,
                tentacleBeast,
                armoredDemon,
                spinedDemon,
                corpulentDemon,
                tortureMaster,
                serpentKnight,
                marquessDWinter,
                shadowKing,
                lordOfFlame,
                venomQueen
            };

            //Act
            List<BaseUnit> actualUnits = _unitsInformationService.GetAllUnitsInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult compareResult = compare.Compare(expectedUnits, actualUnits);
            Assert.IsTrue(compareResult.AreEqual, compareResult.DifferencesString);
        }
    }
}
