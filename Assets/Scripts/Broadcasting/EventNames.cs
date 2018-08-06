using UnityEngine;
using System.Collections;

/*
 * Holder for event names
 * Created By: NeilDG
 */
public class EventNames
{
    public const string ON_UPDATE_SCORE = "ON_UPDATE_SCORE";
    public const string ON_CORRECT_MATCH = "ON_CORRECT_MATCH";
    public const string ON_WRONG_MATCH = "ON_WRONG_MATCH";
    public const string ON_INCREASE_LEVEL = "ON_INCREASE_LEVEL";

    public const string ON_PICTURE_CLICKED = "ON_PICTURE_CLICKED";

    public class X22_Events
    {
        public const string EXTENDED_TRACK_ON_SCAN = "EXTENDED_TRACK_ON_SCAN";
        public const string EXTENDED_TRACK_REMOVE = "EXTENDED_TRACK_REMOVE";
        public const string ITEM_SELECTED = "ITEM_SELECTED";
        public const string BUILDING_SELECTED = "BUILDING_SELECTED";
        public const string HIDE_ALL_SELECTED = "HIDE_ALL_SELECTED";
        public const string DELETE_ALL_SELECTED = "DELETE_ALL_SELECTED";
        public const string SHOW_ALL_SELECTED = "SHOW ALL SELECTED";
    }

    public class ProjectEvents
    {
        public class TutorialEvents
        {
            public const string STEP_ONE_DONE = "STEP_ONE_DONE";
            public const string STEP_TWO_DONE = "STEP_TWO_DONE";
            public const string STEP_THREE_DONE = "STEP_THREE_DONE";
            public const string CHAR_MARKER_LOST = "CHAR_MARKER_LOST";
            public const string CHAR_MARKER_BACK = "CHAR_MARKER_BACK";
            public const string WALL_MARKER_LOST = "WALL_MAKER_LOST";
            public const string WALL_MARKER_BACK = "WALL_MAKER_BACK";

        }

        public class GameProperEvents
        {
            public const string POINT_GAINED = "POINT_GAINED";
            public const string PLAYER_HIT = "PLAYER_HIT";
        }
    }
}







