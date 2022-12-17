double count = 0;
double distance = 12900000;
double FirsFriendSpeed = 5;
double SecondFriendSpeed = 7;
double DogSpeed = 15;
double friend = 2;
double time = 0;
while(distance > 10)
{
    if(friend == 2)
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        distance = distance - ((FirsFriendSpeed + SecondFriendSpeed) * time);
        count++;
        friend = friend - 1;
    }
    if(friend == 1)
    {
        time = distance / (FirsFriendSpeed + DogSpeed);
        distance = distance - ((FirsFriendSpeed + SecondFriendSpeed) * time);
        count++;
        friend = friend + 1;
    }
}
Console.Write($"Собака пробежала {count} раз ");