#!/usr/bin/env ruby
require "libnotify"

puts "+-----------------------+"
puts "1) Critical notification"
puts "2) Normal notification"
puts "3) Low notification"
puts "+-----------------------+"
puts ""

STDOUT.flush
print "What is your choice? "
choice = gets.chomp

if choice.to_i == 1
    puts "You chose: " + choice
    note = Libnotify.new do |notify|
      notify.summary    = "Hey"
      notify.body       = "I'm a critical"
      notify.timeout    = 1.5         # 1.5 (s), 1000 (ms), "2", nil, false
      notify.urgency    = :critical   # :low, :normal, :critical
      notify.append     = true       # default true - append onto existing notification
      notify.transient  = true        # default false - keep the notifications around after display
      notify.icon_path  = Dir.pwd + "/pics/48px-crit.png"
    end
elsif choice.to_i == 2
    puts "You chose: " + choice
    note = Libnotify.new do |notify|
      notify.summary    = "Hey"
      notify.body       = "I'm a normal"
      notify.timeout    = 1.5         # 1.5 (s), 1000 (ms), "2", nil, false
      notify.urgency    = :normal   # :low, :normal, :critical
      notify.append     = true       # default true - append onto existing notification
      notify.transient  = true        # default false - keep the notifications around after display
      notify.icon_path  = Dir.pwd + "/pics/48px-norm.png"
    end
elsif choice.to_i == 3        
    puts "You chose: " + choice
    note = Libnotify.new do |notify|
      notify.summary    = "Hey"
      notify.body       = "I'm a low"
      notify.timeout    = 1.5         # 1.5 (s), 1000 (ms), "2", nil, false
      notify.urgency    = :normal   # :low, :normal, :critical
      notify.append     = true       # default true - append onto existing notification
      notify.transient  = true        # default false - keep the notifications around after display
      notify.icon_path  = Dir.pwd + "/pics/48px-low.png"
    end
else
    puts "You fucked up"
    exit
end

note.show!
