#!/usr/bin/env ruby
require "libnotify"

note = Libnotify.new do |notify|
  notify.summary    = "hello"
  notify.body       = "world"
  notify.timeout    = 1.5         # 1.5 (s), 1000 (ms), "2", nil, false
  notify.urgency    = :critical   # :low, :normal, :critical
  notify.append     = false       # default true - append onto existing notification
  notify.transient  = true        # default false - keep the notifications around after display
  notify.icon_path  = "/home/phil/Pictures/48px-alert.png"
end

note.show!
