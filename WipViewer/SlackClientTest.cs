using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WipViewer
{
    class SlackClientTest
    {

        void TestPostMessage()
        {
            string urlWithAccessToken = "https://hooks.slack.com/services/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";
            SlackClient client = new SlackClient(urlWithAccessToken);

            client.PostMessage(username: "Mr. ", text: "message", channel: "#general");
            

        }
    }
}
