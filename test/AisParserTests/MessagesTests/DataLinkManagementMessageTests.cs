﻿using AisParser;
using AisParser.Messages;
using Shouldly;
using Xunit;

namespace AisParserTests.MessagesTests
{
    public class DataLinkManagementMessageTests : MessageTestBase
    {
        [Fact]
        public void Should_parse_message()
        {
            const string sentence = "!AIVDM,1,1,,B,D03OK@QclNfp00N007pf9H80v9H,2*33";

            var message = Parser.Parse(sentence) as DataLinkManagementMessage;
            message.ShouldNotBeNull();
            message.MessageType.ShouldBe(AisMessageType.DataLinkManagement);
            message.Repeat.ShouldBe(0u);
            message.Mmsi.ShouldBe(3660610u);
            message.Spare.ShouldBe(0u);
            message.Offset1.ShouldBe(1725u);
            message.ReservedSlots1.ShouldBe(1u);
            message.Timeout1.ShouldBe(7u);
            message.Increment1.ShouldBe(750u);
            message.Offset2.ShouldBe(0u);
            message.ReservedSlots2.ShouldBe(1u);
            message.Timeout2.ShouldBe(7u);
            message.Increment2.ShouldBe(0u);
            message.Offset3.ShouldBe(126u);
            message.ReservedSlots3.ShouldBe(2u);
            message.Timeout3.ShouldBe(7u);
            message.Increment3.ShouldBe(150u);
            message.Offset4.ShouldBe(128u);
            message.ReservedSlots4.ShouldBe(3u);
            message.Timeout4.ShouldBe(7u);
            message.Increment4.ShouldBe(150u);
        }
    }
}
