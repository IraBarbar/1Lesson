int count = 0;
int distance = 10000;
int first_friand_speed = 1;
int second_friand_speed = 2;
int dog_speed = 5;
int friend = 2;
int time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (first_friand_speed + dog_speed);
        friend = 2;
    } 
    else
    {
        time = distance / (second_friand_speed + dog_speed);
        friend = 1;
    }
    distance = distance - (first_friand_speed + second_friand_speed) * (time); 
    count++; 
}
Console.WriteLine(count);