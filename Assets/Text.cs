using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Text text;

    private enum States
    {
        introduction, table_0, table_1, table_2, esc_0, esc_1, esc_2, esc_3, rm_0, rm_1, rm_1_Bedroom, rm_1_Bedroom_Desk, rm_1_Bedroom_Bed,
        rm_1_Bedroom_Window, death_0 
    };

    private States myState;

    // Use this for initialization
    void Start()
    {

        myState = States.introduction;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (myState == States.introduction)
        {
            introduction();
        }

        else if (myState == States.table_0)
        {
            table_0();
        }

        else if(myState == States.table_1)
        {
            table_1();
        }

        else if(myState == States.table_2)
        {
            table_2();
        }

        else if (myState == States.esc_0)
        {
            esc_0();
        }

        else if(myState == States.esc_1)
        {
            esc_1();
        }

        else if(myState == States.esc_2)
        {
            esc_2();
        }

        else if(myState == States.esc_3)
        {
            esc_3();
        }

        else if(myState == States.rm_0)
        {
            rm_0();
        }

        else if (myState == States.rm_1)
        {
            rm_1();
        }

        else if (myState == States.rm_1_Bedroom)
        {
            rm_1_Bedroom();
        }

        else if (myState == States.rm_1_Bedroom_Desk)
        {
            rm_1_Bedroom_Desk();
        }

        else if (myState == States.rm_1_Bedroom_Bed)
        {
            rm_1_Bedroom_Bed();
        }

        else if (myState == States.rm_1_Bedroom_Window)
        {
            rm_1_Bedroom_Window();
        }

        else if(myState == States.death_0)
        {
            death_0();
        }
    }

    void introduction()
    {
        text.text = "Your co-worker, Charles, has invited you to his house for dinner. As you knock on the door, you can hear a faint \"...Coming!\" " +
                    "from inside. A few moments later, the door swings open and you are greeted by a wide smile. The smell of something " +
                    "delcious permeates the air as you step inside. \"Come sit down at the table why don't you? \" He says. \n\n" +
                    "Press S to sit.";  
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.table_0;
        }
    }


    // Dining room table
    void table_0()
    {
        text.text = "You sit down at the table and look around the tastefully decorated room. At work, Charles kept his desk impeccably " +
                    "clean, his home is no different apparently.\n\n" +
                    "Press A to ask about girlfriend \n\n" +
                    "Press K to grab the Knife in front of you \n\n" +
                    "Press C to ask about his Children \n\n" +
                    "Press G to get up";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.esc_0;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.death_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.esc_1;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.rm_0;
        }
    }

    void table_1()
    {
        text.text = "You are sitting across from Charles waiting for dinner to finish cooking. It smells delicious, but strangely, unlike anything you have smelt before." +
                    "\"Should be almost done!\" Charles says." +
                    "Press A to ask about girlfriend \n\n" +
                    "Press K to grab the Knife in front of you \n\n" +
                    "Press C to ask about his Children \n\n" +
                    "Press G to get up"; ;
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.esc_0;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.death_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.esc_1;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.rm_0;
        }
    }

    void esc_0()
    {
        text.text = "\"How's Joanna doing?\" you ask. Charles " +
                    "was dating the new office intern for about a month now. She's young and pretty, much like every other girl Charles " +
                    "had taken to. \"Great. A fiesty one for sure.\" He chuckles.\n \"Is she sick?\" you ask, \"Haven't seen her at all this week..\"" +
                    "\"I think she's on vacation.\" he says dismissively. \n\n";
        table_1();
    }

    void death_0()
    {
        text.text = "You pick up the knife in front of you and lunge across the table at Charles. As you swing desparately at him you realize, with sudden horror " +
                    "that it's just made of cheap plastic, painted to ressemble a real knife. A sinister grin flashes over your co-worker's face as he slowly stands up." +
                    "You hear a dull \"crack!\" and a sharp pain pierces your head. Blood fills your eyes as you fall to the ground...\n\n" +
                    "Press ENTER to start over.";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myState = States.introduction;
        }
        
    }

    void esc_1()
    {
        text.text = "\"Bobby still in the slammer huh?\" \"Yeah, people as fucked up as he is shouldn't be allowed anywhere near regular, sane people. Charles pours a" +
                    "glass of wine. \"Want some? Joanna tells me it's pretty good.\"" +
                    "Press T to ask about twins \n\n" +
                    "Press C to ask about crime \n\n" +
                    "Press D to drop it \n\n" +
                    "Press G to get up";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.esc_2;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.esc_3;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.table_0;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.rm_0;
        }
    }

    void esc_2()
    {
        text.text = "\"I know you and your twin brother were super close before the incident.. Can't believe he was capable of something like that.\" \n \"Bobby was always the smarter one." +
                    "It doesn't surprise me that he got away with it as long as he did.\" Charles shrugged. \"Starting with our pet hamster was smart. Easy to overlook.\n\n\"" +
                    "Press C to ask about crime \n\n" +
                    "Press D to drop it \n\n" +
                    "Press G to get up";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.esc_3;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.table_0;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.rm_0;
        }
    }

    void esc_3()
    {
        text.text = "\"Why did he even do those things? I mean killing them was one thing but eating their fucking corpses? How mentally ill do you have to be..\"\n" +
                    "Before he was incarcerated, Bobby seldom ate anything. Mom chalked it up to his pickiness and stubborness, but one night I walked down into the kitchen" +
                    "to get a glass of water and there he was. Standing in front of the fridge with tommorow's steak gripped in both his hands, tearing into it like he hadn't eaten" +
                    "in weeks.\" Visibly shaken, Charles said, \"Thank god he didn't notice I was there, He looked hungry enough to have eaten me too..\"\n\n" +
                    "Press ENTER";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myState = States.table_2;
        }
    }

    void table_2()
    {
        text.text = "You are sitting across from Charles waiting for dinner to finish cooking. It smells delicious, but strangely, unlike anything you have smelt before." +
                    "\"Should be almost done!\" Charles says." +
                    "Press A to ask about girlfriend \n\n" +
                    "Press K to grab the Knife in front of you \n\n" +
                    "Press C to ask about his Children \n\n" +
                    "Press G to get up"; ;
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.esc_0;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.death_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.esc_1;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            myState = States.rm_0;
        }
        
    }

    // Ground floor
    void rm_0()
    {
        text.text = "You stand up and look around the room. \n \"Feel free to look around!\" Charles says pulling out his phone. \"Dinner should be ready soon.\" \n" +
                    "Press U to go upstairs \n\n" +
                    "Press D to go downstairs \n\n" +
                    "Press L to leave the house \n\n" +
                    "Press S to sit back down";
        if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.rm_1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.rm_2;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            text.text = "You don't go out often. Probably better to spend the evening with friends. \n\n" +
                        "Press ENTER";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                myState = States.table_2;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.table_2;
        }
    }

    void rm_1()
    {
        text.text = "You head upstairs. You observe three doors in the dimly lit hallway. Hopefully they aren't locked. \n\n" +
                    "Press B to go into Charles' bedroom \n\n" +
                    "Press W to go into the washroom \n\n" +
                    "Press C to open the hallway closet";
        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.rm_1_Bedroom;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.rm_1_Washroom;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.rm_1_Closet;
        }
    }

    // Upstairs 

    void rm_1_Bedroom()
    {
        // ADD A BEDROOM KEY CONDITION
        text.text = "You step into the bedroom. There's a desk with a chair and a neatly-made bed. \n\n " +
                    "Press D to examine the desk \n\n" +
                    "Press B to examine the bed \n\n" +
                    "Press W to examine the window \n\n" +
                    "Press E to exit to hallway";
        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.rm_1_Bedroom_Desk;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.rm_1_Bedroom_Bed;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.rm_1_Bedroom_Window;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.rm_1;
        }
    }

    void rm_1_Bedroom_Desk()
    {
        text.text = "The desk is absolutely spotless. No dust or lint on it's surface. Inside you find some photographs. \n\n" +
                    "Press P to examine the photographs \n\n" +
                    "Press R to return";
        if (Input.GetKeyDown(KeyCode.P))
        {
            text.text = "There are photographs of many young women. They don't look professionally taken. There is also a picture " +
                        "of Charles. He has a tattoo on his neck. \n\n" +
                        "Press R to return";
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.rm_1_Bedroom;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.rm_1_Bedroom;
        }
    }

    void rm_1_Bedroom_Bed()
    {
        text.text = "The bed is impeccably made. Hard to believe Charles even sleeps here. \n\n" +
                    "Press P to examine pillows \n\n" +
                    "Press S to examine sheets \n\n" +
                    "Press R to return";
        if (Input.GetKeyDown(KeyCode.P))
        {
            text.text = "You rummage through the pillows on the bed. Nothing inside. \n\n" +
                        "Press R to return";
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.rm_1_Bedroom_Bed;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            text.text = "You pull back the sheets. It smells freshly laundered. \n\n" +
                        "Press R to return";
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.rm_1_Bedroom_Bed;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.rm_1_Bedroom;
        }
    }

    void rm_1_Bedroom_Window()
    {
        text.text = "You look through the bedroom window. You can see your black Civic sitting in the driveway. \n\n" +
                    "Press R to return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.rm_1_Bedroom;
        }
    }
}
