// ICE Smarthome
// Dennis Skoy
// Mar 2024

// House Class

class House
{
    private List<Room> rooms;

    public House() { this.rooms = new List<Room>(); }


    // Member Methods
    /** AddRoom */
    public void AddRoom(Room room) { rooms.Add(room); }

}