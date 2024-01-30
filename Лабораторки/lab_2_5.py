def formed_team(players):
    sorted_players = sorted(players, reverse=True)
    team = []
    while sorted_players:
        approved_player = sorted_players.pop(0)

        if not any(approved_player.PP > sum(player.PP for player in team) for team_player in team):
            team.append(approved_player)




class Player:
    def __init__(self, PP):
        self.PP = PP

players = [Player(90), Player(80), Player(95), Player(85)]