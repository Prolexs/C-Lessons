int count = 0;
int distance = 10000;
int FirsFriendSpeed = 5;
int SecondFriendSpeed = 7;
int DogSpeed = 15;
int friend = 2;
int time = 0;
while(distance > 10)
{
    if(friend == 2)
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        distance = distance - (FirsFriendSpeed + SecondFriendSpeed) * time;
        count++;
    }
}
