using Microsoft.Pex.Framework;
using PokerLeagueManager.Common.Tests;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerLeagueManager.Common.Events;
using PokerLeagueManager.Queries.Core.Infrastructure;
using PokerLeagueManager.Queries.Core.EventHandlers;
using PokerLeagueManager.Common.DTO;
using PokerLeagueManager.Common.DTO.DataTransferObjects.Lookups;
// <copyright file="GetPlayerStatisticsHandlerTest.HandleTest.g.cs">Copyright ©  2012</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PokerLeagueManager.Queries.Core.EventHandlers.Tests
{
    public partial class GetPlayerStatisticsHandlerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void HandleTestThrowsNullReferenceException239()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    lookupGamePlayersDto = new LookupGamePlayersDto();
    lookupGamePlayersDto.GameId = s0;
    lookupGamePlayersDto.PlayerName = (string)null;
    lookupGamePlayersDto.Placing = 0;
    lookupGamePlayersDto.Winnings = 0;
    lookupGamePlayersDto.PayIn = 0;
    getPlayerStatisticsDto = new GetPlayerStatisticsDto();
    getPlayerStatisticsDto.PlayerName = (string)null;
    getPlayerStatisticsDto.GamesPlayed = 0;
    getPlayerStatisticsDto.Winnings = 0;
    getPlayerStatisticsDto.PayIn = 0;
    getPlayerStatisticsDto.Profit = 0;
    getPlayerStatisticsDto.ProfitPerGame = 0;
    GetPlayerStatisticsHandler s1 = new GetPlayerStatisticsHandler();
    ((BaseHandler)s1).QueryDataStore = (IQueryDataStore)null;
    LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
    GetPlayerStatisticsDto[] getPlayerStatisticsDtos = new GetPlayerStatisticsDto[1]
      ;
    lookupGamePlayersDtos[0] = lookupGamePlayersDto;
    lookupGamePlayersDtos[1] = lookupGamePlayersDto;
    getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
    this.HandleTest
        (s1, (GameDeletedEvent)null, lookupGamePlayersDtos, getPlayerStatisticsDtos);
}

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void HandleTestThrowsNullReferenceException688()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    FakeQueryDataStore fakeQueryDataStore;
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    lookupGamePlayersDto = new LookupGamePlayersDto();
    lookupGamePlayersDto.GameId = s0;
    lookupGamePlayersDto.PlayerName = (string)null;
    lookupGamePlayersDto.Placing = 0;
    lookupGamePlayersDto.Winnings = 0;
    lookupGamePlayersDto.PayIn = 0;
    getPlayerStatisticsDto = new GetPlayerStatisticsDto();
    getPlayerStatisticsDto.PlayerName = (string)null;
    getPlayerStatisticsDto.GamesPlayed = 0;
    getPlayerStatisticsDto.Winnings = 0;
    getPlayerStatisticsDto.PayIn = 0;
    getPlayerStatisticsDto.Profit = 0;
    getPlayerStatisticsDto.ProfitPerGame = 0;
    fakeQueryDataStore = new FakeQueryDataStore();
    GetPlayerStatisticsHandler s1 = new GetPlayerStatisticsHandler();
    ((BaseHandler)s1).QueryDataStore = (IQueryDataStore)fakeQueryDataStore;
    LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
    GetPlayerStatisticsDto[] getPlayerStatisticsDtos = new GetPlayerStatisticsDto[1]
      ;
    lookupGamePlayersDtos[0] = lookupGamePlayersDto;
    lookupGamePlayersDtos[1] = lookupGamePlayersDto;
    getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
    this.HandleTest
        (s1, (GameDeletedEvent)null, lookupGamePlayersDtos, getPlayerStatisticsDtos);
}

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
public void HandleTest872()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    FakeQueryDataStore fakeQueryDataStore;
    GameDeletedEvent gameDeletedEvent;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      Guid s0 = new Guid
                    (default(int), (short)32, (short)32, default(byte), default(byte), 
                     default(byte), default(byte), default(byte), 
                     default(byte), default(byte), default(byte));
      lookupGamePlayersDto = new LookupGamePlayersDto();
      lookupGamePlayersDto.GameId = s0;
      lookupGamePlayersDto.PlayerName = (string)null;
      lookupGamePlayersDto.Placing = 0;
      lookupGamePlayersDto.Winnings = 0;
      lookupGamePlayersDto.PayIn = 0;
      getPlayerStatisticsDto = new GetPlayerStatisticsDto();
      getPlayerStatisticsDto.PlayerName = (string)null;
      getPlayerStatisticsDto.GamesPlayed = 0;
      getPlayerStatisticsDto.Winnings = 0;
      getPlayerStatisticsDto.PayIn = 0;
      getPlayerStatisticsDto.Profit = 0;
      getPlayerStatisticsDto.ProfitPerGame = 0;
      fakeQueryDataStore = new FakeQueryDataStore();
      gameDeletedEvent = new GameDeletedEvent();
      GetPlayerStatisticsHandler s1 = new GetPlayerStatisticsHandler();
      ((BaseHandler)s1).QueryDataStore = (IQueryDataStore)fakeQueryDataStore;
      LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
      GetPlayerStatisticsDto[] getPlayerStatisticsDtos
         = new GetPlayerStatisticsDto[1];
      lookupGamePlayersDtos[0] = lookupGamePlayersDto;
      lookupGamePlayersDtos[1] = lookupGamePlayersDto;
      getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
      this.HandleTest
          (s1, gameDeletedEvent, lookupGamePlayersDtos, getPlayerStatisticsDtos);
      Assert.IsNotNull((object)s1);
      Assert.IsNotNull(((BaseHandler)s1).QueryDataStore);
      GetPlayerStatisticsDto ovplayerStats
         = observer.GetObservedValue<GetPlayerStatisticsDto>("playerStats");
      Assert.IsNotNull((object)ovplayerStats);
      Assert.AreEqual<string>((string)null, ovplayerStats.PlayerName);
      Assert.AreEqual<int>(0, ovplayerStats.GamesPlayed);
      Assert.AreEqual<int>(0, ovplayerStats.Winnings);
      Assert.AreEqual<int>(0, ovplayerStats.PayIn);
      Assert.AreEqual<int>(0, ovplayerStats.Profit);
      Assert.AreEqual<double>(0, ovplayerStats.ProfitPerGame);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
public void HandleTest213()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    FakeQueryDataStore fakeQueryDataStore;
    GameDeletedEvent gameDeletedEvent;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      lookupGamePlayersDto = new LookupGamePlayersDto();
      lookupGamePlayersDto.GameId = default(Guid);
      lookupGamePlayersDto.PlayerName = (string)null;
      lookupGamePlayersDto.Placing = 0;
      lookupGamePlayersDto.Winnings = 0;
      lookupGamePlayersDto.PayIn = 0;
      getPlayerStatisticsDto = new GetPlayerStatisticsDto();
      getPlayerStatisticsDto.PlayerName = (string)null;
      getPlayerStatisticsDto.GamesPlayed = 0;
      getPlayerStatisticsDto.Winnings = 0;
      getPlayerStatisticsDto.PayIn = 0;
      getPlayerStatisticsDto.Profit = 0;
      getPlayerStatisticsDto.ProfitPerGame = 0;
      fakeQueryDataStore = new FakeQueryDataStore();
      gameDeletedEvent = new GameDeletedEvent();
      GetPlayerStatisticsHandler s0 = new GetPlayerStatisticsHandler();
      ((BaseHandler)s0).QueryDataStore = (IQueryDataStore)fakeQueryDataStore;
      LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
      GetPlayerStatisticsDto[] getPlayerStatisticsDtos
         = new GetPlayerStatisticsDto[1];
      lookupGamePlayersDtos[0] = lookupGamePlayersDto;
      lookupGamePlayersDtos[1] = lookupGamePlayersDto;
      getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
      this.HandleTest
          (s0, gameDeletedEvent, lookupGamePlayersDtos, getPlayerStatisticsDtos);
      Assert.IsNotNull((object)s0);
      Assert.IsNotNull(((BaseHandler)s0).QueryDataStore);
      GetPlayerStatisticsDto ovplayerStats
         = observer.GetObservedValue<GetPlayerStatisticsDto>("playerStats");
      Assert.IsNotNull((object)ovplayerStats);
      Assert.AreEqual<string>((string)null, ovplayerStats.PlayerName);
      Assert.AreEqual<int>(-2, ovplayerStats.GamesPlayed);
      Assert.AreEqual<int>(0, ovplayerStats.Winnings);
      Assert.AreEqual<int>(0, ovplayerStats.PayIn);
      Assert.AreEqual<int>(0, ovplayerStats.Profit);
      Assert.AreEqual<double>(0, ovplayerStats.ProfitPerGame);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
public void HandleTest440()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    FakeQueryDataStore fakeQueryDataStore;
    GameDeletedEvent gameDeletedEvent;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      lookupGamePlayersDto = new LookupGamePlayersDto();
      lookupGamePlayersDto.GameId = default(Guid);
      lookupGamePlayersDto.PlayerName = (string)null;
      lookupGamePlayersDto.Placing = 0;
      lookupGamePlayersDto.Winnings = 1020;
      lookupGamePlayersDto.PayIn = 0;
      getPlayerStatisticsDto = new GetPlayerStatisticsDto();
      getPlayerStatisticsDto.PlayerName = (string)null;
      getPlayerStatisticsDto.GamesPlayed = 0;
      getPlayerStatisticsDto.Winnings = 0;
      getPlayerStatisticsDto.PayIn = 0;
      getPlayerStatisticsDto.Profit = 1021;
      getPlayerStatisticsDto.ProfitPerGame = 0;
      fakeQueryDataStore = new FakeQueryDataStore();
      gameDeletedEvent = new GameDeletedEvent();
      GetPlayerStatisticsHandler s0 = new GetPlayerStatisticsHandler();
      ((BaseHandler)s0).QueryDataStore = (IQueryDataStore)fakeQueryDataStore;
      LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
      GetPlayerStatisticsDto[] getPlayerStatisticsDtos
         = new GetPlayerStatisticsDto[1];
      lookupGamePlayersDtos[0] = lookupGamePlayersDto;
      lookupGamePlayersDtos[1] = lookupGamePlayersDto;
      getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
      this.HandleTest
          (s0, gameDeletedEvent, lookupGamePlayersDtos, getPlayerStatisticsDtos);
      Assert.IsNotNull((object)s0);
      Assert.IsNotNull(((BaseHandler)s0).QueryDataStore);
      GetPlayerStatisticsDto ovplayerStats
         = observer.GetObservedValue<GetPlayerStatisticsDto>("playerStats");
      Assert.IsNotNull((object)ovplayerStats);
      Assert.AreEqual<string>((string)null, ovplayerStats.PlayerName);
      Assert.AreEqual<int>(-2, ovplayerStats.GamesPlayed);
      Assert.AreEqual<int>(-2040, ovplayerStats.Winnings);
      Assert.AreEqual<int>(0, ovplayerStats.PayIn);
      Assert.AreEqual<int>(-1019, ovplayerStats.Profit);
      Assert.AreEqual<double>(509, ovplayerStats.ProfitPerGame);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
[PexRaisedException(typeof(DivideByZeroException))]
public void HandleTestThrowsDivideByZeroException526()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    FakeQueryDataStore fakeQueryDataStore;
    GameDeletedEvent gameDeletedEvent;
    lookupGamePlayersDto = new LookupGamePlayersDto();
    lookupGamePlayersDto.GameId = default(Guid);
    lookupGamePlayersDto.PlayerName = (string)null;
    lookupGamePlayersDto.Placing = 0;
    lookupGamePlayersDto.Winnings = 1020;
    lookupGamePlayersDto.PayIn = 0;
    getPlayerStatisticsDto = new GetPlayerStatisticsDto();
    getPlayerStatisticsDto.PlayerName = (string)null;
    getPlayerStatisticsDto.GamesPlayed = 1;
    getPlayerStatisticsDto.Winnings = 0;
    getPlayerStatisticsDto.PayIn = 0;
    getPlayerStatisticsDto.Profit = 1021;
    getPlayerStatisticsDto.ProfitPerGame = 0;
    fakeQueryDataStore = new FakeQueryDataStore();
    gameDeletedEvent = new GameDeletedEvent();
    GetPlayerStatisticsHandler s0 = new GetPlayerStatisticsHandler();
    ((BaseHandler)s0).QueryDataStore = (IQueryDataStore)fakeQueryDataStore;
    LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
    GetPlayerStatisticsDto[] getPlayerStatisticsDtos = new GetPlayerStatisticsDto[1]
      ;
    lookupGamePlayersDtos[0] = lookupGamePlayersDto;
    lookupGamePlayersDtos[1] = lookupGamePlayersDto;
    getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
    this.HandleTest
        (s0, gameDeletedEvent, lookupGamePlayersDtos, getPlayerStatisticsDtos);
}

[TestMethod]
[PexGeneratedBy(typeof(GetPlayerStatisticsHandlerTest))]
[PexRaisedException(typeof(OverflowException))]
public void HandleTestThrowsOverflowException477()
{
    LookupGamePlayersDto lookupGamePlayersDto;
    GetPlayerStatisticsDto getPlayerStatisticsDto;
    FakeQueryDataStore fakeQueryDataStore;
    GameDeletedEvent gameDeletedEvent;
    lookupGamePlayersDto = new LookupGamePlayersDto();
    lookupGamePlayersDto.GameId = default(Guid);
    lookupGamePlayersDto.PlayerName = (string)null;
    lookupGamePlayersDto.Placing = 0;
    lookupGamePlayersDto.Winnings = 1065353216;
    lookupGamePlayersDto.PayIn = -1909903360;
    getPlayerStatisticsDto = new GetPlayerStatisticsDto();
    getPlayerStatisticsDto.PlayerName = (string)null;
    getPlayerStatisticsDto.GamesPlayed = 0;
    getPlayerStatisticsDto.Winnings = 0;
    getPlayerStatisticsDto.PayIn = 0;
    getPlayerStatisticsDto.Profit = 827772928;
    getPlayerStatisticsDto.ProfitPerGame = 0;
    fakeQueryDataStore = new FakeQueryDataStore();
    gameDeletedEvent = new GameDeletedEvent();
    GetPlayerStatisticsHandler s0 = new GetPlayerStatisticsHandler();
    ((BaseHandler)s0).QueryDataStore = (IQueryDataStore)fakeQueryDataStore;
    LookupGamePlayersDto[] lookupGamePlayersDtos = new LookupGamePlayersDto[2];
    GetPlayerStatisticsDto[] getPlayerStatisticsDtos = new GetPlayerStatisticsDto[1]
      ;
    lookupGamePlayersDtos[0] = lookupGamePlayersDto;
    lookupGamePlayersDtos[1] = lookupGamePlayersDto;
    getPlayerStatisticsDtos[0] = getPlayerStatisticsDto;
    this.HandleTest
        (s0, gameDeletedEvent, lookupGamePlayersDtos, getPlayerStatisticsDtos);
}
    }
}
