using System;

class Program
{
    static void Main(string[] args)
    {

        
        var video1 = new Video("She wasn't one of Us", "Mike Johnson", 295);
        var video2 = new Video("Season 03 of Futurama was Genius (Part 4)", "Wii DuB", 473);
        var video3 = new Video("All California Class Ships. Star Trek: Lower Decks Se.3 Ep.10", "True Trek Tv", 159);
       

        // Add comments to videos
        video1.AddComment(new Comment("@02ujtb00626", "Janeway's interaction with Naomi is one of the MANY reasons she is my favorite Captain. She wasn't condescending about Naomi 's plan, just honest about it. And when Janeway's analysis revealed borg contact, she included Naomi in a way that was encouraging. But most importantly, she heavily implied her crew was family, and they wouldn't give up hope. Janeway is my Captain."));
        video1.AddComment(new Comment("@CeltycSparrow", "I like how Captain Janeway gave Naomi the same respect as she would an adult member of her crew. AND she seemed to admire the child's determination to get Seven home. She didn't just laugh and dismiss her."));
        video1.AddComment(new Comment("@uhejnjd", "I love how Janeway didn't want a visitor but seeing it was Naomi allowed her in (Although she really didn't want to)  then 5 seconds later is all smiles because she realized that this little girl is actually trying."));

        video2.AddComment(new Comment("@zotharr", "She's stuck in an infinite loop, and he's an idiot - perfect description of love xD"));
        video2.AddComment(new Comment("@samalvey8168", "Tax dodge nothing! You take one nap in a ditch at the park and they start declaring you this and that!"));
        video2.AddComment(new Comment("@jordanproudfoot2545", "I'll ruin you like I ruined this company"));

        video3.AddComment(new Comment("@VankeithB.-lx1dy", "One ship, outgunned and helpless. But it makes me feel honored to have other Cali-Class ships out there to watch your back."));
        video3.AddComment(new Comment("@rossdax47", "This scene is what makes Lower Decks so special.And it happens to be one of the Trek moments ever."));
        video3.AddComment(new Comment("@billsargent3407", "I have been a Star Trek fan for 50 years, and that perhaps was the greatest space battle ever...."));


        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds}");
            Console.WriteLine($"Comments: ({video.GetCommentCount()})");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenter} - - - - {comment._text}");
            }

            Console.WriteLine();
        }

    }
}