public interface IPerson: IPersonService
{
    string? PersonName { get; set; }
    string? PersonAddress { get; set; }
    string? PersonEmail { get; set; }
    string? PersonPhone { get; set; }
    string? PersonLastName { get; set; }
}