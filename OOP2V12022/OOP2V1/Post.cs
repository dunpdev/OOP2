namespace OOP2V1
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedDateTime { get; set; }
        private int score = 0;

        public int Score
        {
            get { return score; }
        }
        public Post(string title,string description, string createdDateTime)
        {
            Title = title;
            Description = description;
            CreatedDateTime = createdDateTime;
        }
        public void UpVote()
        {
            score++;
        }
        public void DownVote()
        {
            score--;
        }
        public override string ToString()
        {
            return $"Post with title: {Title} created {CreatedDateTime} has {score}";
        }
    }
}
