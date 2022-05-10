# comm169b-week6
unity stuff

![restaurantFront](https://user-images.githubusercontent.com/58057109/167551298-e15865b5-4590-4c13-9106-e5bd083f57fb.PNG)

Explanation:

1) Since my story is supposed to have the player playing the head chef of a restuarant, this scene is supposed to just be the beginning scene of 
the game, as I want to first introduce the setting of the game. You can see that the restaurant is about to open with a lot of excited and hopeful 
customers.

2) I think my narrative well relatively stay the same, but I want to add a mechanic where if your restaurant is high enough rated with a lot of served
customers, a reviewer will come in, and if you serve their food well, then you win the game. If not, your restaurant rating will take a hit.

Case 1: Not a food reviewer

  Player receives order 
    /               \
Make soup         Make sandwich
    \               /
        Serve to NPC
        /         \
    Correct      Incorrect 
    order         order
    |               |
  increase         decrease
  yelp rating       yelp rating
 
 
 
Case 2: Food reviewer (At least 4 stars with 25 orders completed)
    Player receives special order 
    /               \
Make soup         Make sandwich
    \               /
     Serve to reviewer
        /         \
    Correct      Incorrect 
    order         order
    |               |
win the game!   heavily decreased 
                  yelp rating
