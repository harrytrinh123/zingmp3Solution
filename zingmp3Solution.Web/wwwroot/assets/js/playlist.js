$(document).ready(() => {
    $( ".chart-song-item" ).each(function(index) {
        $(this).on("click", function(){
            var res = $(this).children()[0].value;
            $('#audio').attr("src", "https://localhost:44364/songs/" + res);
            $('#audio').play();
        });
    });

    const heading = $('.song');
    const image = $('#pic');
    const playPic = $('#play-pic')
    const playBtn = $('.btn-toggle-play')
    const progess = document.getElementById('progess')
    const singer = $('.singer')
    var listCard = $('.list-card')
    var playList_icon = $('.playlist-icon')
    var lineProgess = document.getElementById('color-progress')
    var audio = document.getElementById('audio')
    var playing = false;

    const app = {
        currentIndex: 0,
        song: [{
            name: 'Hoa Hải Đường',
            singer: 'Jack',
            path: '../assets/song/Hoa Hai Duong - Jack.mp3',
            image: '../assets/images/playlist/avartar.jpg'
        }],
        render: function() {

        },
        defineProperties: function() {
            Object.defineProperty(this, 'currentSong', {
                get: function() {
                    return this.song[this.currentIndex]
                }
            })
        },
        loadPlayList: function() {
            playList_icon.append(
                `<i class="play-icon far fa-heart" style="font-size: 25px;"></i>
                <i class="play-icon playButton-icon far fa-play-circle"></i>
                <i class="play-icon pauseButton-icon far fa-pause-circle"></i>
                <i class="play-icon fas fa-broadcast-tower" style="font-size: 25px;"></i>`
            )
        },
        loadCurrentSong: function() {
            heading.html(this.currentSong.name)
            image.attr('src', this.currentSong.image)
            playPic.attr('src', this.currentSong.image)
            singer.html(this.currentSong.singer)
            audio.src = this.currentSong.path
            $('#compress').hide()
            playList_icon.hide()
            $('.show').hide()
        },
        handlEvent: function() {

            // thay đổi thời gian theo click thanh time
            progess.onchange = function(even) {
                const seekTime = audio.duration / 100 * even.target.value
                audio.currentTime = seekTime
            }

            //xử lý cd quay
            const imageAnimate = document.getElementById('pic').animate([
                { transform: 'rotate(360deg)' }
            ], {
                duration: 10000,
                iterations: Infinity
            })
            imageAnimate.pause()

            // click phát nhạc
            playBtn.click(function() {
                if (playing) {
                    // pause playing
                    document.getElementById('audio').pause()
                    $('.pauseButton-icon').hide()
                    $('.playButton-icon').show()
                    imageAnimate.pause()
                } else {
                    // Start playing
                    $('.pauseButton-icon').show()
                    $('.playButton-icon').hide()
                    imageAnimate.play()
                    audio.play()
                }

                // thời gian chạy
                audio.addEventListener('timeupdate', function() {
                    const progessTime = Math.floor(audio.currentTime / audio.duration * 100)
                    progess.value = progessTime
                    lineProgess.style.width = progess.value + "%"
                })

                playing = !playing;
            })

            //show full screen
            $('.fa-expand-alt').click(() => {
                $('.show').show(100)
                $('.main').hide()
            })

            //rê chuột vào ảnh 
            listCard.mouseenter(function() {
                    playList_icon.show()
                })
                .mouseleave(function() {
                    playList_icon.hide()
                });
        },
        start: function() {
            this.defineProperties()
            this.loadPlayList()
            this.loadCurrentSong()
            this.handlEvent()

            this.render();
            $('.pauseButton-icon').hide()
        }
    }

    app.start();

})