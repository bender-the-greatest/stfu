#!/usr/bin/env ruby
require 'libnotify'
require 'trollop'

def show_notification(type)
    note = Libnotify.new do |notify|
        notify.summary    = "Shit's happening!"
        notify.body       = "This is a #{type} alert!"
        notify.timeout    = 1.5         # 1.5 (s), 1000 (ms), "2", nil, false
        notify.urgency    = :"#{type}"  # :low, :normal, :critical
        notify.append     = false       # default true - append onto existing notification
        notify.transient  = false       # default false - keep the notifications around after display
        notify.icon_path  = Dir.pwd + "/pics/48px-#{type}.png"
    end
    note.show!
end

opts = Trollop::options do
    opt :watchstring, "Watch vboxmanage for this string", :type=>:string 
    opt :testing, "Testing", :type=>:string
end

def poll_vboxmanage
    iter = 0
    while iter < 30 do
        output = `vboxmanage guestproperty enumerate "Windows" | grep "/LoggedInUsers,"`
        output.match "value: 1"
        show_notification("normal")
        sleep 1
        iter = iter + 1
    end
end

loop do
    puts "+-----------------------+"
    puts "1) Critical notification"
    puts "2) Normal notification"
    puts "3) Low notification"
    puts "4) Poll vboxmanage for 30 seconds"
    puts "5) Quit"
    puts "+-----------------------+"
    puts ""

    STDIN.flush
    STDOUT.flush
    print "What is your choice? "
    choice = gets.chomp    

    if choice.to_i == 1
        puts "You chose: " + choice
        show_notification("critical")
    elsif choice.to_i == 2
        puts "You chose: " + choice
        show_notification("normal")
    elsif choice.to_i == 3        
        puts "You chose: " + choice
        show_notification("low")
    elsif choice.to_i == 4
        poll_vboxmanage
    elsif choice.to_i == 5
        puts "Quitting..."
        break
    else
        puts "You fucked up"
    end
    puts "" 
end
