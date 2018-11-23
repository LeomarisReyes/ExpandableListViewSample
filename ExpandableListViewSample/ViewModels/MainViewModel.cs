using System.Collections.ObjectModel;
using ExpandableListViewSample.Models;

namespace ExpandableListViewSample.ViewModels
{
    public class MainViewModel
    {
        public  ObservableCollection<Music> Musics {get; set;}
        private Music oldMusic;
        public MainViewModel()
        {
            Musics = new ObservableCollection<Music>
            {
                new Music
                {
                    name        = "Time of my life",
                    picture     =  "Music"

                },
                new Music{
                    name        = "Shape of you",
                    picture     =  "Music"
                },
                new Music{
                    name        = "Just the way you are",
                    picture     =  "Music"
                },

            };  
        }

        public void HideOrShowMusic(Music music)
        {
            if(oldMusic == music)
            {
                music.IsVisible = !music.IsVisible;
                UpdateMusic(music);
            }
            else
            {
                if (oldMusic != null)
                {
                    oldMusic.IsVisible = false;
                    UpdateMusic(oldMusic);
                }
                music.IsVisible = true;
                UpdateMusic(music);
            }
            oldMusic = music;
        }

        public void UpdateMusic(Music music)
        {
            var index = Musics.IndexOf(music);
            Musics.Remove(music);
            Musics.Insert(index, music);
        }
    }
}
