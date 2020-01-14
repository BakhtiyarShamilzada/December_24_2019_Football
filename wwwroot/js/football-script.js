(function () {
    var $closeBtn,
        $heading,
        $loadBtn,
        $loading,
        $players,
        $playersAway,
        $playersHome,
        $stage,
        $subHeading,
        $switchBtn,
        $switcher,
        $team,
        $teamListHome,
        $terrain,
        $world,
        ASSET_URL,
        anim,
        data,
        dom,
        events,
        init,
        pos,
        scenes,
        state;

    ASSET_URL = '';

    $stage = null;

    $world = null;

    $terrain = null;

    $team = null;

    $teamListHome = null;

    $players = null;

    $playersHome = null; // Subset of $players

    $playersAway = null; // Subset of $players

    $switchBtn = null;

    $loadBtn = null;

    $closeBtn = null;

    $heading = null;

    $subHeading = null;

    $loading = null;

    $switcher = null;



    data = {
        players: {
            home: [
                {
                    name: '1',
                    asset: '',
                    origin: 'France',
                    height: '1.87m',
                    shirt: '9',
                    pos: 'Forward',
                    dob: '36',
                    goals: 1,
                    games: 16,
                    x: 110,
                    y: -190
                },
                {
                    name: '2',
                    asset: '',
                    origin: 'Wales',
                    height: '1.83m',
                    shirt: '11',
                    pos: 'Midfield',
                    dob: '26',
                    goals: 19,
                    games: 30,
                    x: -110,
                    y: -190
                },
                {
                    name: '3',
                    asset: '',
                    origin: 'Spain',
                    height: '1.70m',
                    shirt: '15',
                    pos: 'Defender',
                    dob: '32',
                    goals: 9,
                    games: 22,
                    x: 150,
                    y: 50
                },
                {
                    name: '4',
                    asset: '',
                    origin: 'Brazil',
                    height: '1.87m',
                    shirt: '16',
                    pos: 'Forward',
                    dob: '22',
                    goals: 21,
                    games: 3,
                    x: 0,
                    y: 100
                },
                {
                    name: '5',
                    asset: '',
                    origin: 'Germany',
                    height: '1.82',
                    shirt: '8',
                    pos: 'Midfield',
                    dob: '25',
                    goals: 0,
                    games: 2,
                    x: -150,
                    y: 50
                },
                {
                    name: '6',
                    asset: '',
                    origin: 'Croatia',
                    height: '1.74m',
                    shirt: '19',
                    pos: 'Midfield',
                    dob: '30',
                    goals: 5,
                    games: 27,
                    x: -200,
                    y: 180
                },
                {
                    name: '7',
                    asset: '',
                    origin: 'Germany',
                    height: '1.79',
                    shirt: '18',
                    pos: 'Defence',
                    dob: '25',
                    goals: 2,
                    games: 25,
                    x: 200,
                    y: 180
                },
                {
                    name: '8',
                    asset: '',
                    origin: 'Spain',
                    height: '1.83m',
                    shirt: '4',
                    pos: 'Defence',
                    dob: '31',
                    goals: 21,
                    games: 1,
                    x: 100,
                    y: 300
                },
                {
                    name: '9',
                    asset: '',
                    origin: 'Brazil',
                    height: '1.88m',
                    shirt: '3',
                    pos: 'Defence',
                    dob: '32',
                    goals: 0,
                    games: 34,
                    x: -100,
                    y: 300
                },
                {
                    name: '10',
                    asset: '',
                    origin: 'Spain',
                    height: '1.85m',
                    shirt: '1',
                    pos: 'Goalie',
                    dob: '34',
                    goals: 0,
                    games: 48,
                    x: 0,
                    y: 410
                }
            ],
            away: [
                {
                    name: '1',
                    asset: '',
                    origin: 'France',
                    height: '1.87m',
                    shirt: '9',
                    pos: 'Forward',
                    dob: '36',
                    goals: 1,
                    games: 16,
                    x: 110,
                    y: -190
                },
                {
                    name: '2',
                    asset: '',
                    origin: 'Wales',
                    height: '1.83m',
                    shirt: '11',
                    pos: 'Midfield',
                    dob: '26',
                    goals: 19,
                    games: 30,
                    x: -110,
                    y: -190
                },
                {
                    name: '3',
                    asset: '',
                    origin: 'Spain',
                    height: '1.70m',
                    shirt: '15',
                    pos: 'Defender',
                    dob: '32',
                    goals: 9,
                    games: 22,
                    x: 150,
                    y: 50
                },
                {
                    name: '4',
                    asset: '',
                    origin: 'Brazil',
                    height: '1.87m',
                    shirt: '16',
                    pos: 'Forward',
                    dob: '22',
                    goals: 21,
                    games: 3,
                    x: 0,
                    y: 100
                },
                {
                    name: '5',
                    asset: '',
                    origin: 'Germany',
                    height: '1.82',
                    shirt: '8',
                    pos: 'Midfield',
                    dob: '25',
                    goals: 0,
                    games: 2,
                    x: -150,
                    y: 50
                },
                {
                    name: '6',
                    asset: '',
                    origin: 'Croatia',
                    height: '1.74m',
                    shirt: '19',
                    pos: 'Midfield',
                    dob: '30',
                    goals: 5,
                    games: 27,
                    x: -200,
                    y: 180
                },
                {
                    name: '7',
                    asset: '',
                    origin: 'Germany',
                    height: '1.79',
                    shirt: '18',
                    pos: 'Defence',
                    dob: '25',
                    goals: 2,
                    games: 25,
                    x: 200,
                    y: 180
                },
                {
                    name: '8',
                    asset: '',
                    origin: 'Spain',
                    height: '1.83m',
                    shirt: '4',
                    pos: 'Defence',
                    dob: '31',
                    goals: 21,
                    games: 1,
                    x: 100,
                    y: 300
                },
                {
                    name: '9',
                    asset: '',
                    origin: 'Brazil',
                    height: '1.88m',
                    shirt: '3',
                    pos: 'Defence',
                    dob: '32',
                    goals: 0,
                    games: 34,
                    x: -100,
                    y: 300
                },
                {
                    name: '10',
                    asset: '',
                    origin: 'Spain',
                    height: '1.85m',
                    shirt: '1',
                    pos: 'Goalie',
                    dob: '34',
                    goals: 0,
                    games: 48,
                    x: 0,
                    y: 410
                }
            ]
        }
    };

    
    $('.game-team-1').each(function () {
        let footballerId = $(this).attr('data-id');
        let positionId = $(this).find('h6').text();
        let image = $(this).find('img').attr('src');
        for (let obj of data.players.home) {
            if (obj.name == positionId) {
                obj.footballerId = footballerId;
                obj.asset = image
            }
        }
    })

        $('.game-team-2').each(function () {
        let footballerId = $(this).attr('data-id');
        let positionId = $(this).find('h6').text();
        let image = $(this).find('img').attr('src');
        for (let obj of data.players.away) {
            if (obj.name == positionId) {
                obj.footballerId = footballerId;
                obj.asset = image
            }
        }
    })

    state = {
        home: true,
        disabHover: false,
        swapSides: function () {
            if (this.home) {
                return this.home = false;
            } else {
                return this.home = true;
            }
        },
        curSide: function () {
            if (this.home) {
                return 'home';
            } else {
                return 'away';
            }
        }
    };

    pos = {
        world: {
            baseX: 0,
            baseY: 0,
            baseZ: -200
        },
        def: {
            goalie: [0, -50]
        }
    };

    dom = {
        addPlayers: function (side) {
            var $el, key, ref, val;
            ref = data.players[side];
            for (key in ref) {
                val = ref[key];
                val.side = side;
                $el = this.addPlayer(val);
                $team.append($el);
            }
            $players = $('.js-player');
            $playersHome = $('.js-player[data-side="home"]');
            return $playersAway = $('.js-player[data-side="away"]');
        },
        addPlayer: function (data) {
            var $el;
            $el = $('<div class="js-player player" data-name="' + data.name + '" data-side="' + data.side + '" data-id="' + data.footballerId + '" data-x="' + data.x + '" data-y="' + data.y + '"></div>');
            $el.append('<div class="player__label"><span>' + data.name + '</span></div>');
            $el.append('<div class="player__img"><img src= ' + data.asset + '></div>');
            $el.prepend('<div class="player__card"> </div>');
            $el.prepend('<div class="player__placeholder"></div>');
            this.populateCard($el.find('.player__card'), data);
            return $el;
        },
        preloadImages: function (preload) {
            var i, promises;
            promises = [];
            i = 0;
            while (i < preload.length) {
                (function (url, promise) {
                    var img;
                    img = new Image;
                    img.onload = function () {
                        return promise.resolve();
                    };
                    return img.src = url;
                })(preload[i], promises[i] = $.Deferred());
                i++;
            }
            return $.when.apply($, promises).done(function () {
                scenes.endLoading();
                return scenes.loadIn(1600);
            });
        },
        populateCard: function ($el, data) {
            return $el.append('<h3>' + data.name + '</h3>' + '<ul class="player__card__list"><li><span>DOB</span><br/>' + data.dob + ' yr</li><li><span>Height</span><br/>' + data.height + '</li><li><span>Origin</span><br/>' + data.origin + '</li></ul>' + '<ul class="player__card__list player__card__list--last"><li><span>Games</span><br/>' + data.games + '</li><li><span>Goals</span><br/>' + data.goals + '</li></ul>');
        },
        displayNone: function ($el) {
            return $el.css('display', 'none');
        }
    };

    events = {
        attachAll: function () {
            $switchBtn.on('click', function (e) {
                var $el;
                e.preventDefault();
                $el = $(this);
                if ($el.hasClass('disabled')) {
                    return;
                }
                scenes.switchSides();
                $switchBtn.removeClass('disabled');
                return $el.addClass('disabled');
            });
            $loadBtn.on('click', function (e) {
                e.preventDefault();
                return scenes.loadIn();
            });
            return $players.on('click', function (e) {
                var $el;
                e.preventDefault();
                $el = $(this);
                if ($('.active').length) {
                    return false;
                }
                $el.addClass('active');
                scenes.focusPlayer($el);
                return setTimeout((function () {
                    return events.attachClose();
                }), 1);
            });
        },
        attachClose: function () {
            return $stage.one('click', function (e) {
                e.preventDefault();
                return scenes.unfocusPlayer();
            });
        }
    };

    scenes = {
        preLoad: function () {
            $teamListHome.velocity({
                opacity: 1
            }, 0);
            $players.velocity({
                opacity: 1
            }, 0);
            $loadBtn.velocity({
                opacity: 1
            }, 0);
            $switcher.velocity({
                opacity: 1
            }, 0);
            $heading.velocity({
                opacity: 1
            }, 0);
            $subHeading.velocity({
                opacity: 1
            }, 0);
            $playersAway.css('display', 'none');
            $world.velocity({
                opacity: 1,
                translateZ: -200,
                translateY: -60
            }, 0);
            return $('main').velocity({
                opacity: 1
            }, 0);
        },
        loadIn: function (delay = 0) {
            var delayInc;
            $world.velocity({
                opacity: 1,
                translateY: 0,
                translateZ: -200
            }, {
                    duration: 1000,
                    delay: delay,
                    easing: 'spring'
                });
            anim.fadeInDir($heading, 300, delay + 600, 0, 30);
            anim.fadeInDir($subHeading, 300, delay + 800, 0, 30);
            anim.fadeInDir($teamListHome, 300, delay + 800, 0, 30);
            anim.fadeInDir($switcher, 300, delay + 900, 0, 30);
            delay += 1200;
            delayInc = 30;
            return anim.dropPlayers($playersHome, delay, delayInc);
        },
        startLoading: function () {
            var images, key, ref, val;
            anim.fadeInDir($loading, 300, 0, 0, -20);
            images = [];
            ref = data.players.home && data.players.away;
            for (key in ref) {
                val = ref[key];
                images.push(ASSET_URL + val.asset);
            }
            //return dom.preloadImages(images);
        },
        endLoading: function () {
            return anim.fadeOutDir($loading, 300, 1000, 0, -20);
        },
        arrangePlayers: function () {
            return $players.each(function () {
                var $el;
                $el = $(this);
                return $el.velocity({
                    translateX: parseInt($el.attr('data-x')),
                    translateZ: parseInt($el.attr('data-y')) // Z is the Y axis on the field
                });
            });
        },
        focusPlayer: function ($el) {
            var shiftY;
            data = $el.data();
            shiftY = data.y;
            if (shiftY > 0) {
                shiftY = data.y / 2;
            }
            $('.js-player[data-side="' + state.curSide() + '"]').not('.active').each(function () {
                var $unfocus;
                $unfocus = $(this);
                return anim.fadeOutDir($unfocus, 300, 0, 0, 0, 0, null, 0.2);
            });
            $world.velocity({
                translateX: pos.world.baseX - data.x,
                translateY: pos.world.baseY,
                translateZ: pos.world.baseZ - shiftY // Z is the Y axis on the field
            }, 600);
            $terrain.velocity({
                opacity: 0.66
            }, 600);
            return this.showPlayerCard($el, 600, 600);
        },
        unfocusPlayer: function () {
            var $el;
            $el = $('.js-player.active');
            data = $el.data();
            anim.fadeInDir($('.js-player[data-side="' + state.curSide() + '"]').not('.active'), 300, 300, 0, 0, 0, null, 0.2);
            $el.removeClass('active');
            $world.velocity({
                translateX: pos.world.baseX,
                translateY: pos.world.baseY,
                translateZ: pos.world.baseZ // Z is the Y axis on the field
            }, 600);
            $terrain.velocity({
                opacity: 1
            }, 600);
            return this.hidePlayerCard($el, 600, 600);
        },
        hidePlayerCard: function ($el, dur, delay) {
            var $card, $image;
            $card = $el.find('.player__card');
            $image = $el.find('.player__img');
            $image.velocity({
                translateY: 0
            }, 300);
            anim.fadeInDir($el.find('.player__label', 200, delay));
            return anim.fadeOutDir($card, 300, 0, 0, -100);
        },
        showPlayerCard: function ($el, dur, delay) {
            var $card, $image;
            $card = $el.find('.player__card');
            $image = $el.find('.player__img');
            $image.velocity({
                translateY: '-=150px'
            }, 300);
            anim.fadeOutDir($el.find('.player__label', 200, delay));
            return anim.fadeInDir($card, 300, 200, 0, 100);
        },
        switchSides: function () {
            var $new, $old, delay, delayInc;
            delay = 0;
            delayInc = 20;
            $old = $playersHome;
            $new = $playersAway;
            if (!state.home) {
                $old = $playersAway;
                $new = $playersHome;
            }
            state.swapSides();
            $old.each(function () {
                var $el;
                $el = $(this);
                anim.fadeOutDir($el, 200, delay, 0, -60, 0);
                anim.fadeOutDir($el.find('.player__label'), 200, delay + 700);
                return delay += delayInc;
            });
            $terrain.velocity({
                rotateY: '+=180deg'
            }, {
                    delay: 150,
                    duration: 1200
                });
            return anim.dropPlayers($new, 1500, 30);
        }
    };

    anim = {
        fadeInDir: function ($el, dur, delay, deltaX = 0, deltaY = 0, deltaZ = 0, easing = null, opacity = 0) {
            $el.css('display', 'block');
            $el.velocity({
                translateX: '-=' + deltaX,
                translateY: '-=' + deltaY,
                translateZ: '-=' + deltaZ
            }, 0);
            return $el.velocity({
                opacity: 1,
                translateX: '+=' + deltaX,
                translateY: '+=' + deltaY,
                translateZ: '+=' + deltaZ
            }, {
                    easing: easing,
                    delay: delay,
                    duration: dur
                });
        },
        fadeOutDir: function ($el, dur, delay, deltaX = 0, deltaY = 0, deltaZ = 0, easing = null, opacity = 0) {
            var display;
            if (!opacity) {
                display = 'none';
            } else {
                display = 'block';
            }
            return $el.velocity({
                opacity: opacity,
                translateX: '+=' + deltaX,
                translateY: '+=' + deltaY,
                translateZ: '+=' + deltaZ
            }, {
                    easing: easing,
                    delay: delay,
                    duration: dur
                }).velocity({
                    opacity: opacity,
                    translateX: '-=' + deltaX,
                    translateY: '-=' + deltaY,
                    translateZ: '-=' + deltaZ
                }, {
                        duration: 0,
                        display: display
                    });
        },
        dropPlayers: function ($els, delay, delayInc) {
            return $els.each(function () {
                var $el;
                $el = $(this);
                $el.css({
                    display: 'block',
                    opacity: 0
                });
                anim.fadeInDir($el, 800, delay, 0, 50, 0, 'spring');
                anim.fadeInDir($el.find('.player__label'), 200, delay + 250);
                return delay += delayInc;
            });
        }
    };

    init = function () {
        $stage = $('.js-stage');
        $world = $('.js-world');
        $switchBtn = $('.js-switch');
        $loadBtn = $('.js-load');
        $heading = $('.js-heading');
        $switcher = $('.js-switcher');
        $closeBtn = $('.js-close');
        $subHeading = $('.js-subheading');
        $terrain = $('.js-terrain');
        $team = $('.js-team');
        $teamListHome = $('.js-team-home');
        $loading = $('.js-loading');
        dom.addPlayers('home');
        dom.addPlayers('away');
        scenes.preLoad();
        scenes.arrangePlayers();
        events.attachAll();
        return scenes.startLoading();
    };

    $(document).ready(function () {
        return init();
    });

}).call(this);

//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiIiwic291cmNlUm9vdCI6IiIsInNvdXJjZXMiOlsiPGFub255bW91cz4iXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7QUFBQSxNQUFBLFNBQUEsRUFBQSxRQUFBLEVBQUEsUUFBQSxFQUFBLFFBQUEsRUFBQSxRQUFBLEVBQUEsWUFBQSxFQUFBLFlBQUEsRUFBQSxNQUFBLEVBQUEsV0FBQSxFQUFBLFVBQUEsRUFBQSxTQUFBLEVBQUEsS0FBQSxFQUFBLGFBQUEsRUFBQSxRQUFBLEVBQUEsTUFBQSxFQUFBLFNBQUEsRUFBQSxJQUFBLEVBQUEsSUFBQSxFQUFBLEdBQUEsRUFBQSxNQUFBLEVBQUEsSUFBQSxFQUFBLEdBQUEsRUFBQSxNQUFBLEVBQUE7O0VBQUEsU0FBQSxHQUFZOztFQUVaLE1BQUEsR0FBZ0I7O0VBQ2hCLE1BQUEsR0FBZ0I7O0VBQ2hCLFFBQUEsR0FBZ0I7O0VBQ2hCLEtBQUEsR0FBZ0I7O0VBQ2hCLGFBQUEsR0FBZ0I7O0VBQ2hCLFFBQUEsR0FBZ0I7O0VBQ2hCLFlBQUEsR0FBZ0IsS0FSaEI7O0VBU0EsWUFBQSxHQUFnQixLQVRoQjs7RUFVQSxVQUFBLEdBQWdCOztFQUNoQixRQUFBLEdBQWdCOztFQUNoQixTQUFBLEdBQWdCOztFQUNoQixRQUFBLEdBQWdCOztFQUNoQixXQUFBLEdBQWdCOztFQUNoQixRQUFBLEdBQWdCOztFQUNoQixTQUFBLEdBQWdCOztFQUVoQixJQUFBLEdBQ0k7SUFBQSxPQUFBLEVBQ0k7TUFBQSxJQUFBLEVBQU07UUFDRjtVQUFFLElBQUEsRUFBTSxTQUFSO1VBQW1CLEtBQUEsRUFBTyxnQkFBMUI7VUFBNEMsTUFBQSxFQUFRLE1BQXBEO1VBQTRELE1BQUEsRUFBUSxPQUFwRTtVQUE2RSxLQUFBLEVBQU8sSUFBcEY7VUFBMEYsR0FBQSxFQUFLLFNBQS9GO1VBQTBHLEdBQUEsRUFBSyxJQUEvRztVQUFxSCxLQUFBLEVBQU8sQ0FBNUg7VUFBK0gsS0FBQSxFQUFPLEVBQXRJO1VBQTBJLENBQUEsRUFBRyxHQUE3STtV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Q0FBQSxDQUFBO1dBQ2QsSUFBQSxDQUFBO0VBRGMsQ0FBbEI7QUEzVUEiLCJzb3VyY2VzQ29udGVudCI6WyJBU1NFVF9VUkwgPSAnaHR0cHM6Ly9zMy11cy13ZXN0LTIuYW1hem9uYXdzLmNvbS9zLmNkcG4uaW8vMjE1MDU5LydcblxuJHN0YWdlICAgICAgICA9IG51bGxcbiR3b3JsZCAgICAgICAgPSBudWxsXG4kdGVycmFpbiAgICAgID0gbnVsbFxuJHRlYW0gICAgICAgICA9IG51bGxcbiR0ZWFtTGlzdEhvbWUgPSBudWxsXG4kcGxheWVycyAgICAgID0gbnVsbFxuJHBsYXllcnNIb21lICA9IG51bGwgIyBTdWJzZXQgb2YgJHBsYXllcnNcbiRwbGF5ZXJzQXdheSAgPSBudWxsICMgU3Vic2V0IG9mICRwbGF5ZXJzXG4kc3dpdGNoQnRuICAgID0gbnVsbFxuJGxvYWRCdG4gICAgICA9IG51bGxcbiRjbG9zZUJ0biAgICAgPSBudWxsXG4kaGVhZGluZyAgICAgID0gbnVsbFxuJHN1YkhlYWRpbmcgICA9IG51bGxcbiRsb2FkaW5nICAgICAgPSBudWxsXG4kc3dpdGNoZXIgICAgID0gbnVsbFxuXG5kYXRhID1cbiAgICBwbGF5ZXJzOlxuICAgICAgICBob21lOiBbXG4gICAgICAgICAgICB7IG5hbWU6ICdQaXphcnJvJywgYXNzZXQ6ICdibS1waXphcnJvLmpwZycsIG9yaWdpbjogJ1BlcnUnLCBoZWlnaHQ6ICcxLjg0bScsIHNoaXJ0OiAnMTQnLCBwb3M6ICdGb3J3YXJkJywgZG9iOiAnMzYnLCBnb2FsczogMSwgZ2FtZXM6IDE2LCB4OiAxMTAsIHk6IC0xOTAgfVxuICAgICAgICAgICAgeyBuYW1lOiAnUm9iYmVuJywgYXNzZXQ6ICdibS1yb2JiZW4ucG5nJywgb3JpZ2luOiAnSG9sbGFuZCcsIGhlaWdodDogJzEuODBtJywgc2hpcnQ6ICcxMCcsIHBvczogJ0ZvcndhcmQnLCBkb2I6ICczMicsIGdvYWxzOiAxOSwgZ2FtZXM6IDMwLCB4OiAtMTEwLCB5OiAtMTkwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ1JpbGJlcnknLCBhc3NldDogJ2JtLXJpbGJlcnkuanBnJywgb3JpZ2luOiAnRnJhbmNlJywgaGVpZ2h0OiAnMS43MG0nLCBzaGlydDogJzcnLCBwb3M6ICdNaWRmaWVsZCcsIGRvYjogJzMyJywgZ29hbHM6IDksIGdhbWVzOiAyMiwgeDogMTUwLCB5OiA1MCB9XG4gICAgICAgICAgICB7IG5hbWU6ICdTY2h3ZWluc3RlaWdlcicsIGFzc2V0OiAnYm0tc2Nod2VpbnN0ZWlnZXIuanBnJywgb3JpZ2luOiAnR2VybWFueScsIGhlaWdodDogJzEuODdtJywgc2hpcnQ6ICcyNCcsIHBvczogJ0ZvcndhcmQnLCBkb2I6ICczMScsIGdvYWxzOiAyMSwgZ2FtZXM6IDMsIHg6IDAsIHk6IDEwMCB9XG4gICAgICAgICAgICB7IG5hbWU6ICdNYXJ0aW5leicsIGFzc2V0OiAnYm0tbWFydGluZXouanBnJywgb3JpZ2luOiAnU3BhaW4nLCBoZWlnaHQ6ICcxLjkwbScsIHNoaXJ0OiAnOCcsIHBvczogJ01pZGZpZWxkJywgZG9iOiAnMjgnLCBnb2FsczogMCwgZ2FtZXM6IDIsIHg6IC0xNTAsIHk6IDUwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ0FsYWJhJywgYXNzZXQ6ICdibS1hbGFiYS5qcGcnLCBvcmlnaW46ICdBdXN0cmlhJywgaGVpZ2h0OiAnMS44MG0nLCBzaGlydDogJzI3JywgcG9zOiAnRGVmZW5jZScsIGRvYjogJzI0JywgZ29hbHM6IDUsIGdhbWVzOiAyNywgeDogLTIwMCwgeTogMTgwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ0xhaG0nLCBhc3NldDogJ2JtLWxhaG0uanBnJywgb3JpZ2luOiAnR2VybWFueScsIGhlaWdodDogJzEuNzAnLCBzaGlydDogJzIxJywgcG9zOiAnRGVmZW5jZScsIGRvYjogJzMyJywgZ29hbHM6IDIsIGdhbWVzOiAyNSwgeDogMjAwLCB5OiAxODAgfVxuICAgICAgICAgICAgeyBuYW1lOiAnQmVuYXRpYScsIGFzc2V0OiAnYm0tYmVuYXRpYS5qcGcnLCBvcmlnaW46ICdGcmFuY2UnLCBoZWlnaHQ6ICcxLjg3bScsIHNoaXJ0OiAnNScsIHBvczogJ0RlZmVuY2UnLCBkb2I6ICczMScsIGdvYWxzOiAyMSwgZ2FtZXM6IDEsIHg6IDEwMCwgeTogMzAwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ0RhbnRlJywgYXNzZXQ6ICdibS1kYW50ZS5qcGcnLCBvcmlnaW46ICdCcmF6aWwnLCBoZWlnaHQ6ICcxLjg3bScsIHNoaXJ0OiAnNCcsIHBvczogJ0RlZmVuY2UnLCBkb2I6ICczMicsIGdvYWxzOiAwLCBnYW1lczogMzQsIHg6IC0xMDAsIHk6IDMwMCB9XG4gICAgICAgICAgICB7IG5hbWU6ICdOZXVlcicsIGFzc2V0OiAnYm0tbmV1ZXIuanBnJywgb3JpZ2luOiAnR2VybWFueScsIGhlaWdodDogJzEuOTNtJywgc2hpcnQ6ICcxJywgcG9zOiAnR29hbGllJywgZG9iOiAnMjknLCBnb2FsczogMCwgZ2FtZXM6IDQ4LCB4OiAwLCB5OiA0MTAgfVxuICAgICAgICBdXG4gICAgICAgIGF3YXk6IFtcbiAgICAgICAgICAgIHsgbmFtZTogJ0JlbnplbWEnLCBhc3NldDogJ3JtLWJlbnplbWEuanBnJywgb3JpZ2luOiAnRnJhbmNlJywgaGVpZ2h0OiAnMS44N20nLCBzaGlydDogJzknLCBwb3M6ICdGb3J3YXJkJywgZG9iOiAnMzYnLCBnb2FsczogMSwgZ2FtZXM6IDE2LCB4OiAxMTAsIHk6IC0xOTAgfVxuICAgICAgICAgICAgeyBuYW1lOiAnQmFsZScsIGFzc2V0OiAncm0tYmFsZS5qcGcnLCBvcmlnaW46ICdXYWxlcycsIGhlaWdodDogJzEuODNtJywgc2hpcnQ6ICcxMScsIHBvczogJ01pZGZpZWxkJywgZG9iOiAnMjYnLCBnb2FsczogMTksIGdhbWVzOiAzMCwgeDogLTExMCwgeTogLTE5MCB9XG4gICAgICAgICAgICB7IG5hbWU6ICdjYXJ2YWphbCcsIGFzc2V0OiAncm0tY2FydmFqYWwuanBnJywgb3JpZ2luOiAnU3BhaW4nLCBoZWlnaHQ6ICcxLjcwbScsIHNoaXJ0OiAnMTUnLCBwb3M6ICdEZWZlbmRlcicsIGRvYjogJzMyJywgZ29hbHM6IDksIGdhbWVzOiAyMiwgeDogMTUwLCB5OiA1MCB9XG4gICAgICAgICAgICB7IG5hbWU6ICdTaWx2YScsIGFzc2V0OiAncm0tc2lsdmEuanBnJywgb3JpZ2luOiAnQnJhemlsJywgaGVpZ2h0OiAnMS44N20nLCBzaGlydDogJzE2JywgcG9zOiAnRm9yd2FyZCcsIGRvYjogJzIyJywgZ29hbHM6IDIxLCBnYW1lczogMywgeDogMCwgeTogMTAwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ0tyb29zJywgYXNzZXQ6ICdybS1rcm9vcy5qcGcnLCBvcmlnaW46ICdHZXJtYW55JywgaGVpZ2h0OiAnMS44MicsIHNoaXJ0OiAnOCcsIHBvczogJ01pZGZpZWxkJywgZG9iOiAnMjUnLCBnb2FsczogMCwgZ2FtZXM6IDIsIHg6IC0xNTAsIHk6IDUwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ01vZHJpYycsIGFzc2V0OiAncm0tbW9kcmljLmpwZycsIG9yaWdpbjogJ0Nyb2F0aWEnLCBoZWlnaHQ6ICcxLjc0bScsIHNoaXJ0OiAnMTknLCBwb3M6ICdNaWRmaWVsZCcsIGRvYjogJzMwJywgZ29hbHM6IDUsIGdhbWVzOiAyNywgeDogLTIwMCwgeTogMTgwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ05hY2hvJywgYXNzZXQ6ICdybS1uYWNoby5qcGcnLCBvcmlnaW46ICdHZXJtYW55JywgaGVpZ2h0OiAnMS43OScsIHNoaXJ0OiAnMTgnLCBwb3M6ICdEZWZlbmNlJywgZG9iOiAnMjUnLCBnb2FsczogMiwgZ2FtZXM6IDI1LCB4OiAyMDAsIHk6IDE4MCB9XG4gICAgICAgICAgICB7IG5hbWU6ICdSYW1vcycsIGFzc2V0OiAncm0tcmFtb3MuanBnJywgb3JpZ2luOiAnU3BhaW4nLCBoZWlnaHQ6ICcxLjgzbScsIHNoaXJ0OiAnNCcsIHBvczogJ0RlZmVuY2UnLCBkb2I6ICczMScsIGdvYWxzOiAyMSwgZ2FtZXM6IDEsIHg6IDEwMCwgeTogMzAwIH1cbiAgICAgICAgICAgIHsgbmFtZTogJ1BlcGUnLCBhc3NldDogJ3JtLXBlcGUuanBnJywgb3JpZ2luOiAnQnJhemlsJywgaGVpZ2h0OiAnMS44OG0nLCBzaGlydDogJzMnLCBwb3M6ICdEZWZlbmNlJywgZG9iOiAnMzInLCBnb2FsczogMCwgZ2FtZXM6IDM0LCB4OiAtMTAwLCB5OiAzMDAgfVxuICAgICAgICAgICAgeyBuYW1lOiAnQ2FzaWxsYXMnLCBhc3NldDogJ3JtLWNhc2lsbGFzLmpwZycsIG9yaWdpbjogJ1NwYWluJywgaGVpZ2h0OiAnMS44NW0nLCBzaGlydDogJzEnLCBwb3M6ICdHb2FsaWUnLCBkb2I6ICczNCcsIGdvYWxzOiAwLCBnYW1lczogNDgsIHg6IDAsIHk6IDQxMCB9XG4gICAgICAgIF1cblxuc3RhdGUgPVxuICAgIGhvbWU6IHRydWVcbiAgICBkaXNhYkhvdmVyOiBmYWxzZVxuICAgIHN3YXBTaWRlczogLT5cbiAgICAgICAgaWYgQGhvbWUgdGhlbiBAaG9tZSA9IGZhbHNlIGVsc2UgQGhvbWUgPSB0cnVlXG4gICAgY3VyU2lkZTogLT5cbiAgICAgICAgaWYgQGhvbWUgdGhlbiAnaG9tZScgZWxzZSAnYXdheSdcblxucG9zID1cbiAgICB3b3JsZDpcbiAgICAgICAgYmFzZVg6IDBcbiAgICAgICAgYmFzZVk6IDBcbiAgICAgICAgYmFzZVo6IC0yMDBcbiAgICBkZWY6XG4gICAgICAgIGdvYWxpZTogWzAsLTUwXVxuXG5kb20gPVxuICAgIGFkZFBsYXllcnM6IChzaWRlKSAtPlxuICAgICAgICBmb3Iga2V5LCB2YWwgb2YgZGF0YS5wbGF5ZXJzW3NpZGVdXG4gICAgICAgICAgICB2YWwuc2lkZT0gc2lkZVxuICAgICAgICAgICAgJGVsID0gQGFkZFBsYXllciB2YWxcbiAgICAgICAgICAgICR0ZWFtLmFwcGVuZCAkZWxcblxuICAgICAgICAkcGxheWVycyA9ICQoJy5qcy1wbGF5ZXInKVxuICAgICAgICAkcGxheWVyc0hvbWUgPSAkKCcuanMtcGxheWVyW2RhdGEtc2lkZT1cImhvbWVcIl0nKVxuICAgICAgICAkcGxheWVyc0F3YXkgPSAkKCcuanMtcGxheWVyW2RhdGEtc2lkZT1cImF3YXlcIl0nKVxuXG5cbiAgICBhZGRQbGF5ZXI6IChkYXRhKSAtPlxuICAgICAgICAkZWwgPSAkICc8ZGl2IGNsYXNzPVwianMtcGxheWVyIHBsYXllclwiIGRhdGEtbmFtZT1cIicgKyBkYXRhLm5hbWUgKyAnXCIgZGF0YS1zaWRlPVwiJyArIGRhdGEuc2lkZSArICdcIiBkYXRhLXg9XCInICsgZGF0YS54ICsgJ1wiIGRhdGEteT1cIicgKyBkYXRhLnkgKyAnXCI+PC9kaXY+J1xuICAgICAgICAkZWwuYXBwZW5kICc8ZGl2IGNsYXNzPVwicGxheWVyX19sYWJlbFwiPjxzcGFuPicgKyBkYXRhLm5hbWUgKyAnPC9zcGFuPjwvZGl2PidcbiAgICAgICAgJGVsLmFwcGVuZCAnPGRpdiBjbGFzcz1cInBsYXllcl9faW1nXCI+PGltZyBzcmM9ICcgKyBBU1NFVF9VUkwgKyBkYXRhLmFzc2V0ICsgJz48L2Rpdj4nXG4gICAgICAgICRlbC5wcmVwZW5kICc8ZGl2IGNsYXNzPVwicGxheWVyX19jYXJkXCI+IDwvZGl2PidcbiAgICAgICAgJGVsLnByZXBlbmQgJzxkaXYgY2xhc3M9XCJwbGF5ZXJfX3BsYWNlaG9sZGVyXCI+PC9kaXY+J1xuICAgICAgICBAcG9wdWxhdGVDYXJkICRlbC5maW5kKCcucGxheWVyX19jYXJkJyksIGRhdGFcbiAgICAgICAgJGVsXG5cbiAgICBwcmVsb2FkSW1hZ2VzOiAocHJlbG9hZCkgLT5cbiAgICAgICAgcHJvbWlzZXMgPSBbXVxuICAgICAgICBpID0gMFxuICAgICAgICB3aGlsZSBpIDwgcHJlbG9hZC5sZW5ndGhcbiAgICAgICAgICAoKHVybCwgcHJvbWlzZSkgLT5cbiAgICAgICAgICAgIGltZyA9IG5ldyBJbWFnZVxuICAgICAgICAgICAgaW1nLm9ubG9hZCA9IC0+IHByb21pc2UucmVzb2x2ZSgpXG4gICAgICAgICAgICBpbWcuc3JjID0gdXJsXG4gICAgICAgICAgKSBwcmVsb2FkW2ldLCBwcm9taXNlc1tpXSA9ICQuRGVmZXJyZWQoKVxuICAgICAgICAgIGkrK1xuICAgICAgICAkLndoZW4uYXBwbHkoJCwgcHJvbWlzZXMpLmRvbmUgLT5cbiAgICAgICAgICAgIHNjZW5lcy5lbmRMb2FkaW5nKClcbiAgICAgICAgICAgIHNjZW5lcy5sb2FkSW4oMTYwMClcblxuXG4gICAgcG9wdWxhdGVDYXJkOiAoJGVsLCBkYXRhKSAtPlxuICAgICAgICAkZWwuYXBwZW5kICc8aDM+JyArIGRhdGEubmFtZSArICc8L2gzPicgK1xuICAgICAgICAgICAgJzx1bCBjbGFzcz1cInBsYXllcl9fY2FyZF9fbGlzdFwiPjxsaT48c3Bhbj5ET0I8L3NwYW4+PGJyLz4nICsgZGF0YS5kb2IgKyAnIHlyPC9saT48bGk+PHNwYW4+SGVpZ2h0PC9zcGFuPjxici8+JyArIGRhdGEuaGVpZ2h0ICsgJzwvbGk+PGxpPjxzcGFuPk9yaWdpbjwvc3Bhbj48YnIvPicgKyBkYXRhLm9yaWdpbiArICc8L2xpPjwvdWw+JyArXG4gICAgICAgICAgICAnPHVsIGNsYXNzPVwicGxheWVyX19jYXJkX19saXN0IHBsYXllcl9fY2FyZF9fbGlzdC0tbGFzdFwiPjxsaT48c3Bhbj5HYW1lczwvc3Bhbj48YnIvPicgKyBkYXRhLmdhbWVzICsgJzwvbGk+PGxpPjxzcGFuPkdvYWxzPC9zcGFuPjxici8+JyArIGRhdGEuZ29hbHMgKyAnPC9saT48L3VsPidcblxuICAgIGRpc3BsYXlOb25lOiAoJGVsKSAtPlxuICAgICAgICAkZWwuY3NzICdkaXNwbGF5JywgJ25vbmUnXG5cbmV2ZW50cyA9XG4gICAgYXR0YWNoQWxsOiAtPlxuICAgICAgICAkc3dpdGNoQnRuLm9uICdjbGljaycsIChlKSAtPlxuICAgICAgICAgICAgZS5wcmV2ZW50RGVmYXVsdCgpXG4gICAgICAgICAgICAkZWwgPSAkKHRoaXMpXG4gICAgICAgICAgICByZXR1cm4gaWYgJGVsLmhhc0NsYXNzICdkaXNhYmxlZCdcbiAgICAgICAgICAgIHNjZW5lcy5zd2l0Y2hTaWRlcygpXG4gICAgICAgICAgICAkc3dpdGNoQnRuLnJlbW92ZUNsYXNzICdkaXNhYmxlZCdcbiAgICAgICAgICAgICRlbC5hZGRDbGFzcyAnZGlzYWJsZWQnXG5cbiAgICAgICAgJGxvYWRCdG4ub24gJ2NsaWNrJywgKGUpIC0+XG4gICAgICAgICAgICBlLnByZXZlbnREZWZhdWx0KClcbiAgICAgICAgICAgIHNjZW5lcy5sb2FkSW4oKVxuXG4gICAgICAgICRwbGF5ZXJzLm9uICdjbGljaycsIChlKSAtPlxuICAgICAgICAgICAgZS5wcmV2ZW50RGVmYXVsdCgpXG4gICAgICAgICAgICAkZWwgPSAkKHRoaXMpXG4gICAgICAgICAgICBpZiAkKCcuYWN0aXZlJykubGVuZ3RoIHRoZW4gcmV0dXJuIGZhbHNlXG4gICAgICAgICAgICAkZWwuYWRkQ2xhc3MgJ2FjdGl2ZSdcbiAgICAgICAgICAgIHNjZW5lcy5mb2N1c1BsYXllcigkZWwpXG4gICAgICAgICAgICBzZXRUaW1lb3V0ICggLT4gZXZlbnRzLmF0dGFjaENsb3NlKCkpLCAxXG5cbiAgICBhdHRhY2hDbG9zZTogLT5cbiAgICAgICAgJHN0YWdlLm9uZSAnY2xpY2snLCAoZSkgLT5cbiAgICAgICAgICAgIGUucHJldmVudERlZmF1bHQoKVxuICAgICAgICAgICAgc2NlbmVzLnVuZm9jdXNQbGF5ZXIoKVxuXG5zY2VuZXMgPVxuICAgIHByZUxvYWQ6IC0+XG4gICAgICAgICR0ZWFtTGlzdEhvbWUudmVsb2NpdHkgeyBvcGFjaXR5OiAwIH0sIDBcbiAgICAgICAgJHBsYXllcnMudmVsb2NpdHkgeyBvcGFjaXR5OiAwIH0sIDBcbiAgICAgICAgJGxvYWRCdG4udmVsb2NpdHkgeyBvcGFjaXR5OiAwIH0sIDBcbiAgICAgICAgJHN3aXRjaGVyLnZlbG9jaXR5IHsgb3BhY2l0eTogMCB9LCAwXG4gICAgICAgICRoZWFkaW5nLnZlbG9jaXR5IHsgb3BhY2l0eTogMCB9LCAwXG4gICAgICAgICRzdWJIZWFkaW5nLnZlbG9jaXR5IHsgb3BhY2l0eTogMCB9LCAwXG4gICAgICAgICRwbGF5ZXJzQXdheS5jc3MgJ2Rpc3BsYXknLCAnbm9uZSdcbiAgICAgICAgJHdvcmxkLnZlbG9jaXR5IHsgb3BhY2l0eTogMCwgdHJhbnNsYXRlWjogLTIwMCwgdHJhbnNsYXRlWTogLTYwIH0sIDBcbiAgICAgICAgJCgnbWFpbicpLnZlbG9jaXR5IHsgb3BhY2l0eTogMSB9LCAwXG5cbiAgICBsb2FkSW46IChkZWxheSA9IDApIC0+XG4gICAgICAgICR3b3JsZC52ZWxvY2l0eSB7IG9wYWNpdHk6IDEsIHRyYW5zbGF0ZVk6IDAsIHRyYW5zbGF0ZVo6IC0yMDAgfSwgeyBkdXJhdGlvbjogMTAwMCwgZGVsYXk6IGRlbGF5LCBlYXNpbmc6ICdzcHJpbmcnIH1cbiAgICAgICAgYW5pbS5mYWRlSW5EaXIoJGhlYWRpbmcsIDMwMCwgKGRlbGF5ICsgNjAwKSwgMCwgMzApXG4gICAgICAgIGFuaW0uZmFkZUluRGlyKCRzdWJIZWFkaW5nLCAzMDAsIChkZWxheSArIDgwMCksIDAsIDMwKVxuICAgICAgICBhbmltLmZhZGVJbkRpcigkdGVhbUxpc3RIb21lLCAzMDAsIChkZWxheSArIDgwMCksIDAsIDMwKVxuICAgICAgICBhbmltLmZhZGVJbkRpcigkc3dpdGNoZXIsIDMwMCwgKGRlbGF5ICsgOTAwKSwgMCwgMzApXG5cbiAgICAgICAgZGVsYXkgKz0gMTIwMFxuICAgICAgICBkZWxheUluYyA9IDMwXG4gICAgICAgIGFuaW0uZHJvcFBsYXllcnMoJHBsYXllcnNIb21lLCBkZWxheSwgZGVsYXlJbmMpXG5cbiAgICBzdGFydExvYWRpbmc6IC0+XG4gICAgICAgIGFuaW0uZmFkZUluRGlyICRsb2FkaW5nLCAzMDAsIDAsIDAsIC0yMFxuICAgICAgICBpbWFnZXMgPSBbXVxuICAgICAgICBmb3Iga2V5LCB2YWwgb2YgZGF0YS5wbGF5ZXJzLmhvbWUgYW5kIGRhdGEucGxheWVycy5hd2F5XG4gICAgICAgICAgICBpbWFnZXMucHVzaCBBU1NFVF9VUkwgKyB2YWwuYXNzZXRcblxuICAgICAgICBkb20ucHJlbG9hZEltYWdlcyhpbWFnZXMpXG5cbiAgICBlbmRMb2FkaW5nOiAtPlxuICAgICAgICBhbmltLmZhZGVPdXREaXIgJGxvYWRpbmcsIDMwMCwgMTAwMCwgMCwgLTIwXG5cbiAgICBhcnJhbmdlUGxheWVyczogLT5cbiAgICAgICAgJHBsYXllcnMuZWFjaCAtPlxuICAgICAgICAgICAgJGVsID0gJCh0aGlzKVxuXG4gICAgICAgICAgICAkZWwudmVsb2NpdHlcbiAgICAgICAgICAgICAgICB0cmFuc2xhdGVYOiBwYXJzZUludCAkZWwuYXR0cignZGF0YS14JylcbiAgICAgICAgICAgICAgICB0cmFuc2xhdGVaOiBwYXJzZUludCAkZWwuYXR0cignZGF0YS15JykgIyBaIGlzIHRoZSBZIGF4aXMgb24gdGhlIGZpZWxkXG5cbiAgICBmb2N1c1BsYXllcjogKCRlbCkgLT5cbiAgICAgICAgZGF0YSA9ICRlbC5kYXRhKClcbiAgICAgICAgc2hpZnRZID0gZGF0YS55XG5cbiAgICAgICAgaWYgc2hpZnRZID4gMCB0aGVuIHNoaWZ0WSA9IChkYXRhLnkgLyAyKVxuXG4gICAgICAgICQoJy5qcy1wbGF5ZXJbZGF0YS1zaWRlPVwiJyArIHN0YXRlLmN1clNpZGUoKSArICdcIl0nKS5ub3QoJy5hY3RpdmUnKS5lYWNoIC0+XG4gICAgICAgICAgICAkdW5mb2N1cyA9ICQodGhpcylcbiAgICAgICAgICAgIGFuaW0uZmFkZU91dERpciAkdW5mb2N1cywgMzAwLCAwLCAwLCAwLCAwLCBudWxsLCAwLjJcblxuICAgICAgICAkd29ybGQudmVsb2NpdHlcbiAgICAgICAgICAgIHRyYW5zbGF0ZVg6IChwb3Mud29ybGQuYmFzZVggLSBkYXRhLngpXG4gICAgICAgICAgICB0cmFuc2xhdGVZOiAocG9zLndvcmxkLmJhc2VZKVxuICAgICAgICAgICAgdHJhbnNsYXRlWjogKHBvcy53b3JsZC5iYXNlWiAtIHNoaWZ0WSkgIyBaIGlzIHRoZSBZIGF4aXMgb24gdGhlIGZpZWxkXG5cbiAgICAgICAgLCA2MDBcblxuICAgICAgICAkdGVycmFpbi52ZWxvY2l0eVxuICAgICAgICAgICAgb3BhY2l0eTogMC42NlxuICAgICAgICAsIDYwMFxuXG4gICAgICAgIEBzaG93UGxheWVyQ2FyZCAkZWwsIDYwMCwgNjAwXG5cbiAgICB1bmZvY3VzUGxheWVyOiAtPlxuICAgICAgICAkZWwgPSAkKCcuanMtcGxheWVyLmFjdGl2ZScpXG4gICAgICAgIGRhdGEgPSAkZWwuZGF0YSgpXG4gICAgICAgIGFuaW0uZmFkZUluRGlyICQoJy5qcy1wbGF5ZXJbZGF0YS1zaWRlPVwiJyArIHN0YXRlLmN1clNpZGUoKSArICdcIl0nKS5ub3QoJy5hY3RpdmUnKSwgMzAwLCAzMDAsIDAsIDAsIDAsIG51bGwsIDAuMlxuICAgICAgICAkZWwucmVtb3ZlQ2xhc3MgJ2FjdGl2ZSdcbiAgICAgICAgJHdvcmxkLnZlbG9jaXR5XG4gICAgICAgICAgICB0cmFuc2xhdGVYOiAocG9zLndvcmxkLmJhc2VYKVxuICAgICAgICAgICAgdHJhbnNsYXRlWTogKHBvcy53b3JsZC5iYXNlWSlcbiAgICAgICAgICAgIHRyYW5zbGF0ZVo6IChwb3Mud29ybGQuYmFzZVopICMgWiBpcyB0aGUgWSBheGlzIG9uIHRoZSBmaWVsZFxuXG4gICAgICAgICwgNjAwXG5cbiAgICAgICAgJHRlcnJhaW4udmVsb2NpdHlcbiAgICAgICAgICAgIG9wYWNpdHk6IDFcbiAgICAgICAgLCA2MDBcblxuICAgICAgICBAaGlkZVBsYXllckNhcmQgJGVsLCA2MDAsIDYwMFxuXG4gICAgaGlkZVBsYXllckNhcmQ6ICgkZWwsIGR1ciwgZGVsYXkpIC0+XG4gICAgICAgICRjYXJkID0gJGVsLmZpbmQgJy5wbGF5ZXJfX2NhcmQnXG4gICAgICAgICRpbWFnZSA9ICRlbC5maW5kICcucGxheWVyX19pbWcnXG4gICAgICAgICRpbWFnZS52ZWxvY2l0eVxuICAgICAgICAgICAgdHJhbnNsYXRlWTogMFxuICAgICAgICAsIDMwMFxuICAgICAgICBhbmltLmZhZGVJbkRpciAkZWwuZmluZCAnLnBsYXllcl9fbGFiZWwnLCAyMDAsIGRlbGF5XG4gICAgICAgIGFuaW0uZmFkZU91dERpciAkY2FyZCwgMzAwLCAwLCAwLCAtMTAwXG5cbiAgICBzaG93UGxheWVyQ2FyZDogKCRlbCwgZHVyLCBkZWxheSkgLT5cbiAgICAgICAgJGNhcmQgPSAkZWwuZmluZCAnLnBsYXllcl9fY2FyZCdcbiAgICAgICAgJGltYWdlID0gJGVsLmZpbmQgJy5wbGF5ZXJfX2ltZydcbiAgICAgICAgJGltYWdlLnZlbG9jaXR5XG4gICAgICAgICAgICB0cmFuc2xhdGVZOiAnLT0xNTBweCdcbiAgICAgICAgLCAzMDBcbiAgICAgICAgYW5pbS5mYWRlT3V0RGlyICRlbC5maW5kICcucGxheWVyX19sYWJlbCcsIDIwMCwgZGVsYXlcbiAgICAgICAgYW5pbS5mYWRlSW5EaXIgJGNhcmQsIDMwMCwgMjAwLCAwLCAxMDBcblxuICAgIHN3aXRjaFNpZGVzOiAtPlxuICAgICAgICBkZWxheSA9IDBcbiAgICAgICAgZGVsYXlJbmMgPSAyMFxuXG4gICAgICAgICRvbGQgPSAkcGxheWVyc0hvbWVcbiAgICAgICAgJG5ldyA9ICRwbGF5ZXJzQXdheVxuICAgICAgICBpZiAhc3RhdGUuaG9tZVxuICAgICAgICAgICAgJG9sZCA9ICRwbGF5ZXJzQXdheVxuICAgICAgICAgICAgJG5ldyA9ICRwbGF5ZXJzSG9tZVxuXG4gICAgICAgIHN0YXRlLnN3YXBTaWRlcygpXG5cbiAgICAgICAgJG9sZC5lYWNoIC0+XG4gICAgICAgICAgICAkZWwgPSAkKHRoaXMpXG4gICAgICAgICAgICBhbmltLmZhZGVPdXREaXIoJGVsLCAyMDAsIGRlbGF5LCAwLCAtNjAsIDApXG4gICAgICAgICAgICBhbmltLmZhZGVPdXREaXIoJGVsLmZpbmQoJy5wbGF5ZXJfX2xhYmVsJyksIDIwMCwgKGRlbGF5ICsgNzAwKSlcbiAgICAgICAgICAgIGRlbGF5ICs9IGRlbGF5SW5jXG5cbiAgICAgICAgJHRlcnJhaW4udmVsb2NpdHkgeyByb3RhdGVZOiAnKz0xODBkZWcnIH0sIHsgZGVsYXk6IDE1MCwgZHVyYXRpb246IDEyMDAgfVxuICAgICAgICBhbmltLmRyb3BQbGF5ZXJzKCRuZXcsIDE1MDAsIDMwKVxuXG5hbmltID1cbiAgICBmYWRlSW5EaXI6ICgkZWwsIGR1ciwgZGVsYXksIGRlbHRhWCA9IDAsIGRlbHRhWSA9IDAsIGRlbHRhWiA9IDAsIGVhc2luZyA9IG51bGwsIG9wYWNpdHkgPSAwKSAtPlxuICAgICAgICAkZWwuY3NzICdkaXNwbGF5JywgJ2Jsb2NrJ1xuXG4gICAgICAgICRlbC52ZWxvY2l0eVxuICAgICAgICAgICAgdHJhbnNsYXRlWDogJy09JyArIGRlbHRhWFxuICAgICAgICAgICAgdHJhbnNsYXRlWTogJy09JyArIGRlbHRhWVxuICAgICAgICAgICAgdHJhbnNsYXRlWjogJy09JyArIGRlbHRhWlxuICAgICAgICAsIDBcblxuICAgICAgICAkZWwudmVsb2NpdHlcbiAgICAgICAgICAgIG9wYWNpdHk6IDFcbiAgICAgICAgICAgIHRyYW5zbGF0ZVg6ICcrPScgKyBkZWx0YVhcbiAgICAgICAgICAgIHRyYW5zbGF0ZVk6ICcrPScgKyBkZWx0YVlcbiAgICAgICAgICAgIHRyYW5zbGF0ZVo6ICcrPScgKyBkZWx0YVpcbiAgICAgICAgLFxuICAgICAgICAgICAgZWFzaW5nOiBlYXNpbmdcbiAgICAgICAgICAgIGRlbGF5OiBkZWxheVxuICAgICAgICAgICAgZHVyYXRpb246IGR1clxuXG4gICAgZmFkZU91dERpcjogKCRlbCwgZHVyLCBkZWxheSwgZGVsdGFYID0gMCwgZGVsdGFZID0gMCwgZGVsdGFaID0gMCwgZWFzaW5nID0gbnVsbCwgb3BhY2l0eSA9IDApIC0+XG4gICAgICAgIGlmICFvcGFjaXR5XG4gICAgICAgICAgICBkaXNwbGF5ID0gJ25vbmUnXG4gICAgICAgIGVsc2VcbiAgICAgICAgICAgIGRpc3BsYXkgPSAnYmxvY2snXG5cbiAgICAgICAgJGVsLnZlbG9jaXR5XG4gICAgICAgICAgICBvcGFjaXR5OiBvcGFjaXR5XG4gICAgICAgICAgICB0cmFuc2xhdGVYOiAnKz0nICsgZGVsdGFYXG4gICAgICAgICAgICB0cmFuc2xhdGVZOiAnKz0nICsgZGVsdGFZXG4gICAgICAgICAgICB0cmFuc2xhdGVaOiAnKz0nICsgZGVsdGFaXG4gICAgICAgICxcbiAgICAgICAgICAgIGVhc2luZzogZWFzaW5nXG4gICAgICAgICAgICBkZWxheTogZGVsYXlcbiAgICAgICAgICAgIGR1cmF0aW9uOiBkdXJcbiAgICAgICAgLnZlbG9jaXR5XG4gICAgICAgICAgICBvcGFjaXR5OiBvcGFjaXR5XG4gICAgICAgICAgICB0cmFuc2xhdGVYOiAnLT0nICsgZGVsdGFYXG4gICAgICAgICAgICB0cmFuc2xhdGVZOiAnLT0nICsgZGVsdGFZXG4gICAgICAgICAgICB0cmFuc2xhdGVaOiAnLT0nICsgZGVsdGFaXG4gICAgICAgICxcbiAgICAgICAgICAgIGR1cmF0aW9uOiAwXG4gICAgICAgICAgICBkaXNwbGF5OiBkaXNwbGF5XG5cblxuICAgIGRyb3BQbGF5ZXJzOiAoJGVscywgZGVsYXksIGRlbGF5SW5jKSAtPlxuICAgICAgICAkZWxzLmVhY2ggLT5cbiAgICAgICAgICAgICRlbCA9ICQodGhpcylcbiAgICAgICAgICAgICRlbC5jc3NcbiAgICAgICAgICAgICAgICBkaXNwbGF5IDogJ2Jsb2NrJ1xuICAgICAgICAgICAgICAgIG9wYWNpdHkgOiAwXG5cbiAgICAgICAgICAgIGFuaW0uZmFkZUluRGlyKCRlbCwgODAwLCBkZWxheSwgMCwgNTAsIDAsICdzcHJpbmcnKVxuICAgICAgICAgICAgYW5pbS5mYWRlSW5EaXIoJGVsLmZpbmQoJy5wbGF5ZXJfX2xhYmVsJyksIDIwMCwgKGRlbGF5ICsgMjUwKSlcbiAgICAgICAgICAgIGRlbGF5ICs9IGRlbGF5SW5jXG5cbmluaXQgPSAtPlxuICAgICRzdGFnZSAgICAgICAgPSAkKCcuanMtc3RhZ2UnKVxuICAgICR3b3JsZCAgICAgICAgPSAkKCcuanMtd29ybGQnKVxuICAgICRzd2l0Y2hCdG4gICAgPSAkKCcuanMtc3dpdGNoJylcbiAgICAkbG9hZEJ0biAgICAgID0gJCgnLmpzLWxvYWQnKVxuICAgICRoZWFkaW5nICAgICAgPSAkKCcuanMtaGVhZGluZycpXG4gICAgJHN3aXRjaGVyICAgICA9ICQoJy5qcy1zd2l0Y2hlcicpXG4gICAgJGNsb3NlQnRuICAgICA9ICQoJy5qcy1jbG9zZScpXG4gICAgJHN1YkhlYWRpbmcgICA9ICQoJy5qcy1zdWJoZWFkaW5nJylcbiAgICAkdGVycmFpbiAgICAgID0gJCgnLmpzLXRlcnJhaW4nKVxuICAgICR0ZWFtICAgICAgICAgPSAkKCcuanMtdGVhbScpXG4gICAgJHRlYW1MaXN0SG9tZSA9ICQoJy5qcy10ZWFtLWhvbWUnKVxuICAgICRsb2FkaW5nICAgICAgPSAkKCcuanMtbG9hZGluZycpXG5cbiAgICBkb20uYWRkUGxheWVycygnaG9tZScpXG4gICAgZG9tLmFkZFBsYXllcnMoJ2F3YXknKVxuICAgIHNjZW5lcy5wcmVMb2FkKClcbiAgICBzY2VuZXMuYXJyYW5nZVBsYXllcnMoKVxuICAgIGV2ZW50cy5hdHRhY2hBbGwoKVxuICAgIHNjZW5lcy5zdGFydExvYWRpbmcoKVxuXG4kKGRvY3VtZW50KS5yZWFkeSAtPlxuICAgIGluaXQoKSJdfQ==
//# sourceURL=coffeescript