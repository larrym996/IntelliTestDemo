// <copyright file="GetPlayerStatisticsHandlerTest.cs">Copyright ©  2012</copyright>
using System;
using System.Linq;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerLeagueManager.Common.Events;
using PokerLeagueManager.Queries.Core.EventHandlers;
using Microsoft.Pex.Framework.Using;
using PokerLeagueManager.Common.Tests;
using PokerLeagueManager.Common.DTO;
using PokerLeagueManager.Common.DTO.DataTransferObjects.Lookups;


namespace PokerLeagueManager.Queries.Core.EventHandlers.Tests
{
    /// <summary>This class contains parameterized unit tests for GetPlayerStatisticsHandler</summary>
    [PexClass(typeof(GetPlayerStatisticsHandler))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexUseType(typeof(FakeQueryDataStore))]
    [TestClass]
    public partial class GetPlayerStatisticsHandlerTest
    {
        /// <summary>Test stub for Handle(GameDeletedEvent)</summary>
        [PexMethod]
        public void HandleTest(
            [PexAssumeUnderTest]GetPlayerStatisticsHandler target,
            GameDeletedEvent e,
            LookupGamePlayersDto[] lookupGamePlayers,
            GetPlayerStatisticsDto[] getPlayerStatistics
        )
        {
            // assume 
            PexAssume.IsNotNull(lookupGamePlayers);
            PexAssume.IsTrue(lookupGamePlayers.Length == 2);
            PexAssume.IsNotNull(lookupGamePlayers[0]);
            PexAssume.IsNotNull(lookupGamePlayers[1]);
            PexAssume.IsNotNull(getPlayerStatistics);
            PexAssume.IsTrue(getPlayerStatistics.Length == 1);
            PexAssume.IsNotNull(getPlayerStatistics[0]);
            PexAssume.IsTrue(lookupGamePlayers[0].PlayerName == getPlayerStatistics[0].PlayerName);

            // arrange 
            foreach (var lookupGamePlayer in lookupGamePlayers)
            {
                target.QueryDataStore.Insert<LookupGamePlayersDto>(lookupGamePlayer);
            }
            target.QueryDataStore.Insert<GetPlayerStatisticsDto>(getPlayerStatistics[0]);

            // act
            target.Handle(e);

            // assert 
            var playerStats = target.QueryDataStore.GetData<GetPlayerStatisticsDto>().Single();
            PexObserve.ValueAtEndOfTest("playerStats", playerStats);
        }
    }
}
