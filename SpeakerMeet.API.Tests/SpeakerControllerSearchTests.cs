using System;
using Xunit;
using SpeakerMeet.API.Controllers; //<-- directive to add
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
    }
}