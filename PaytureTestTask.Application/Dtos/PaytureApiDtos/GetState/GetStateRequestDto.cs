namespace PaytureTestTask.Application.Dtos.PaytureApiDtos.GetState
{
    public class GetStateRequestDto
    {
        public string Key { get; set; } = "Merchant";
        public string OrderId { get; set; }
    }
}
