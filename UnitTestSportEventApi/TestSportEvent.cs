using Microsoft.AspNetCore.Mvc;
using Moq;
using SportEventApi.Controllers;
using SportEventApi.DBModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSportEventApi
{
    public class TestSportEvent
    {
        private readonly SportEventsController _sportEventController;


        // Must update the data in SportEvent to get the correct result
        [Fact]
        public async Task ReturnNowDateEvent()
        {
            var mockRepo = new Mock<SportEventsContext>();
            //mockRepo.Setup(repo=>repo.)
            var controller = new SportEventsController(mockRepo.Object);
            var result = await controller.GetSportEvents();
            var actionResult = Assert.IsType<ActionResult<List<SportEvent>>>(result);
            var returnValue = Assert.IsType<List<SportEvent>>(actionResult.Value);
            List <SportEvent> sportEvents = new List<SportEvent>
            {
                new SportEvent(3, new System.DateTime(2019, 7, 4), "SC CORINTHIANS SP VS.SANTOS FC", 2.6f, 1.5f, 1.8f)
            };
            Assert.Equal(sportEvents[0], returnValue[0]);
        }
    }
}
