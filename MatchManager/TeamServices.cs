using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MatchManager
{
    public class TeamServices
    {
        public void AddPlayer(Player player)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.players.Add(player);
                dataBase.SaveChanges();
            }
        }

        public void AddCoach(Coach coach)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.coaches.Add(coach);
                dataBase.SaveChanges();
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.doctors.Add(doctor);
                dataBase.SaveChanges();
            }
        }

        public void AddLeader(Leader leader)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.leaders.Add(leader);
                dataBase.SaveChanges();
            }
        }

        public void AddReferee(Referee referee)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.referees.Add(referee);
                dataBase.SaveChanges();
            }
        }

        public void AddPlayerMatch(PlayerMatch playerMatch)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.playerMatches.Add(playerMatch);
                dataBase.SaveChanges();
            }
        }

        public List<Team> GetAllTeams()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.teams.ToList<Team>();
            }
        }

        public List<Referee> GetAllReferees()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.referees.ToList<Referee>();
            }
        }

        public List<Player> GetAllPlayers()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.ToList<Player>();
            }
        }

        public int GetNumOfMalePlayer()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.ToList<Player>().Where(player => player.sex == "男").Count();
            }
        }

        public int GetNumOfFemalePlayer()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.ToList<Player>().Where(player => player.sex == "女").Count();
            }
        }

        public int GetNumOfAllMalePlayersOfMajor()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.ToList<Player>().Where(player => player.ismajor == "YES" && player.sex == "男").Count();
            }
        }

        public int GetNumOfAllFemalePlayersOfMajor()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.ToList<Player>().Where(player => player.ismajor == "YES" && player.sex == "女").Count();
            }
        }

        public void ChangeMalePlayerOfMajor() //改变东道主男队员的编号
        {
            using (var dataBase = new MatchSystemDB())
            {
                var tempList = dataBase.players.Where(player => player.ismajor == "YES" && player.sex == "男").ToList<Player>();
                foreach (Player tempPlayer in tempList)
                {
                    tempPlayer.idplayer = (int.Parse(tempPlayer.idplayer) + 2).ToString();
                    dataBase.players.Attach(tempPlayer);
                    dataBase.Entry(tempPlayer).State = EntityState.Modified;
                }
                dataBase.SaveChanges();
            }
        }

        public void ChangeFemalePlayerOfMajor() //改变东道主女队员的编号
        {
            using (var dataBase = new MatchSystemDB())
            {
                var tempList = dataBase.players.Where(player => player.ismajor == "YES" && player.sex == "女").ToList<Player>();
                foreach (Player tempPlayer in tempList)
                {
                    tempPlayer.idplayer = (int.Parse(tempPlayer.idplayer) + 2).ToString();
                    dataBase.players.Attach(tempPlayer);
                    dataBase.Entry(tempPlayer).State = EntityState.Modified;
                }
                dataBase.SaveChanges();
            }
        }

        public string GetIDOfMatch(string name, string sex, string age)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.matches.SingleOrDefault(match => match.name == name && match.sex == sex && match.age == age).idmatch;
            }
        }

        public Team GetTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.teams.SingleOrDefault(team => team.idteam == idteam);
            }
        }

        public void ChangeTeam(Team team)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.teams.Attach(team);
                dataBase.Entry(team).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public int GetNumOfAllPlayerMatches()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.playerMatches.ToList<PlayerMatch>().Count;
            }
        }

        public int GetNumOfAllPlayers()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.ToList<Player>().Count;
            }
        }

        public List<PlayerMatch> GetAllPlayerMatchesOfNoneGroup(string idmatch)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.playerMatches.Where(playerMatch => (playerMatch.idgroup == "" || playerMatch.idgroup == null) && playerMatch.idmatch == idmatch).ToList<PlayerMatch>();
            }
        }

        public List<Group> GetAllGroupsOfID(string idmatch)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.groups.Where(group => group.idmatch == idmatch).ToList<Group>();
            }
        }

        public int GetNumOfAllGroups()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.groups.ToList().Count;
            }
        }

        public List<PlayerMatch> GetAllPlayerMatchesOfGroup(string idmatch, string idgroup)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.playerMatches.Where(playerMatch => playerMatch.idmatch == idmatch && playerMatch.idgroup == idgroup).ToList<PlayerMatch>();
            }
        }

        public void AddGroup(Group group)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.groups.Add(group);
                dataBase.SaveChanges();
            }
        }

        public void ChangePlayerMatch(PlayerMatch playerMatch)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.playerMatches.Attach(playerMatch);
                dataBase.Entry(playerMatch).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public int GetNumOfAllRefereeGroup()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.refereeGroups.ToList<RefereeGroup>().Count;
            }
        }

        public List<Referee> GetAllRefereesOfNotMajor()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.referees.Where(referee => referee.ismajor == "NO").ToList<Referee>();
            }
        }

        public void AddRefereeGroup(RefereeGroup refereeGroup)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.refereeGroups.Add(refereeGroup);
                dataBase.SaveChanges();
            }
        }

        public bool IsRefereeGroupExist(string idgroup, string idreferee)
        {
            using (var dataBase = new MatchSystemDB())
            {
                if (dataBase.refereeGroups.SingleOrDefault(refereeGroup => refereeGroup.idgroup == idgroup && refereeGroup.idreferee == idreferee) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<RefereeGroup> GetAllRefereeGroupsOfID(string idgroup)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.refereeGroups.Where(refereeGroup => refereeGroup.idgroup == idgroup).ToList<RefereeGroup>();
            }
        }

        public void RemoveRefereeGroup(RefereeGroup refereeGroup)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.refereeGroups.Remove(dataBase.refereeGroups.SingleOrDefault(temp => temp.num == refereeGroup.num));
                dataBase.SaveChanges();
            }
        }

        public List<string> GetAllIDOfRefereeGroup(string idgroup)
        {
            using (var dataBase = new MatchSystemDB())
            {
                List<string> ids = new List<string>();
                foreach (RefereeGroup refereeGroup in dataBase.refereeGroups)
                {
                    if (refereeGroup.idgroup == idgroup)
                    {
                        ids.Add(refereeGroup.idreferee);
                    }
                }
                return ids;
            }
        }

        public string GetNameOfReferee(string idreferee)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.referees.SingleOrDefault(referee => referee.id == idreferee).name;
            }
        }

        public string GetNameOfPlayer(string num)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.SingleOrDefault(player => player.num == num).name;
            }
        }

        public PlayerMatch GetPlayerMatch(string idplayer, string idmatch)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.playerMatches.SingleOrDefault(playerMatch => playerMatch.idplayer == idplayer && playerMatch.idmatch == idmatch);
            }
        }

        public void AddFile(File file)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.files.Add(file);
                dataBase.SaveChanges();
            }
        }

        public void ChangeFile(File file)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.files.Attach(file);
                dataBase.Entry(file).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public byte[] GetPicOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.files.SingleOrDefault(file => file.idteam == idteam).file;
            }
        }

        public List<Player> GetAllPlayersOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.Where(player => player.idteam == idteam).ToList<Player>();
            }
        }

        public List<PlayerMatch> GetPlayerMatch(string idplayer)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.playerMatches.Where(playerMatch => playerMatch.idplayer == idplayer).ToList<PlayerMatch>();
            }
        }

        public void ChangePlayer(Player player)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.players.Attach(player);
                dataBase.Entry(player).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public void ChangeLeader(Leader leader)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.leaders.Attach(leader);
                dataBase.Entry(leader).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public void ChangeDoctor(Doctor doctor)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.doctors.Attach(doctor);
                dataBase.Entry(doctor).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public void ChangeCoach(Coach coach)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.coaches.Attach(coach);
                dataBase.Entry(coach).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public void ChangeReferee(Referee referee)
        {
            using (var dataBase = new MatchSystemDB())
            {
                dataBase.referees.Attach(referee);
                dataBase.Entry(referee).State = EntityState.Modified;
                dataBase.SaveChanges();
            }
        }

        public List<Match> GetAllMatches()
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.matches.ToList<Match>();
            }
        }

        public List<PlayerMatch> GetPlayerMatchOfMatch(string idmatch)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.playerMatches.Where(playermatch => playermatch.idmatch == idmatch).ToList<PlayerMatch>();
            }
        }

        public List<Player> GetPlayerOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.players.Where(player => player.idteam == idteam).ToList<Player>();
            }
        }

        public List<Leader> GetLeaderOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.leaders.Where(leader => leader.idteam == idteam).ToList<Leader>();
            }
        }

        public List<Doctor> GetDoctorOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.doctors.Where(doctor => doctor.idteam == idteam).ToList<Doctor>();
            }
        }

        public List<Coach> GetCoachOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.coaches.Where(coach => coach.idteam == idteam).ToList<Coach>();
            }
        }

        public List<Referee> GetRefereeOfTeam(string idteam)
        {
            using (var dataBase = new MatchSystemDB())
            {
                return dataBase.referees.Where(referee => referee.idteam == idteam).ToList<Referee>();
            }
        }
    }
}