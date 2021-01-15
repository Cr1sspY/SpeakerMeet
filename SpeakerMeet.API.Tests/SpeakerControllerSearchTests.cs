using System;
using Xunit;
using SpeakerMeet.API.Controllers; //<-- directive to add
using Microsoft.AspNetCore.Mvc;

namespace SpeakerMeet.API.Tests
{
    public class SpeakerControllerSearchTests //<-- to rename
    {
        [Fact(Skip = "����� �� ���������")]
        public void ItExists()
        {
            var controller = new SpeakerController();
        }

        [Fact]
        public void ItHasSearch() //��������� ������� ������ �����
        {
            var controller = new SpeakerController();
            controller.Search("Jos");
        }

        [Fact]
        public void ItReturnsOkObjectResult()
        { 
            var controller = new SpeakerController();
            var result = controller.Search("Jos");
            Assert.NotNull(result);                    //����� ������ ���������?
            Assert.IsType<OkObjectResult>(result);     //��������� ��?
        }
    }
}