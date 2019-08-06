using System;

namespace Ex2_StackOverflowPost
{
    class Post
    {
        public string _title { get; private set; }
        public string _description { get; private set; }
        public DateTime _date { get; private set; }
        public int _voteCount { get; private set; }

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._date = DateTime.Now;
            this._voteCount = 0;
        }

        public void Upvote()
        {
            this._voteCount++;
        }

        public void Downvote()
        {
            this._voteCount--;
        }

        public int SeeVoteValue()
        {
            return this._voteCount;
        }
    }
}
