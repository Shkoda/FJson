namespace Shkoda.Telegram.Client
module GeneratedTypes = 
    type boolFalse = 
        static member Constructor = -1132882121

    type boolTrue = 
        static member Constructor = -1720552011

    type Bool = 
        |BoolFalse of boolFalse 
        |BoolTrue of boolTrue 

    type _true = 
        static member Constructor = 1072550713

    type True = 
        |True of _true 


    type Vector<'t>  = 
         static member Constructor = 481674261

    type error = 
        {_code : int; _text : string} with
        static member Constructor = -994444869

    type Error = 
        |Error of error 

    type _null = 
        static member Constructor = 1450380236

    type Null = 
        |Null of _null 

    type inputPeerEmpty = 
        static member Constructor = 2134579434

    type inputPeerSelf = 
        static member Constructor = 2107670217

    type inputPeerContact = 
        {_user_id : int} with
        static member Constructor = 270785512

    type inputPeerForeign = 
        {_user_id : int; _access_hash : int64} with
        static member Constructor = -1690012891

    type inputPeerChat = 
        {_chat_id : int} with
        static member Constructor = 396093539

    type InputPeer = 
        |InputPeerEmpty of inputPeerEmpty 
        |InputPeerSelf of inputPeerSelf 
        |InputPeerContact of inputPeerContact 
        |InputPeerForeign of inputPeerForeign 
        |InputPeerChat of inputPeerChat 

    type inputUserEmpty = 
        static member Constructor = -1182234929

    type inputUserSelf = 
        static member Constructor = -138301121

    type inputUserContact = 
        {_user_id : int} with
        static member Constructor = -2031530139

    type inputUserForeign = 
        {_user_id : int; _access_hash : int64} with
        static member Constructor = 1700689151

    type InputUser = 
        |InputUserEmpty of inputUserEmpty 
        |InputUserSelf of inputUserSelf 
        |InputUserContact of inputUserContact 
        |InputUserForeign of inputUserForeign 

    type inputPhoneContact = 
        {_client_id : int64; _phone : string; _first_name : string; _last_name : string} with
        static member Constructor = -208488460

    type InputContact = 
        |InputPhoneContact of inputPhoneContact 

    type inputFile = 
        {_id : int64; _parts : int; _name : string; _md5_checksum : string} with
        static member Constructor = -181407105

    type inputFileBig = 
        {_id : int64; _parts : int; _name : string} with
        static member Constructor = -95482955

    type InputFile = 
        |InputFile of inputFile 
        |InputFileBig of inputFileBig 

    type inputGeoPointEmpty = 
        static member Constructor = -457104426

    type inputGeoPoint = 
        {_lat : double; _long : double} with
        static member Constructor = -206066487

    type InputGeoPoint = 
        |InputGeoPointEmpty of inputGeoPointEmpty 
        |InputGeoPoint of inputGeoPoint 

    type inputPhotoEmpty = 
        static member Constructor = 483901197

    type inputPhoto = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = -74070332

    type InputPhoto = 
        |InputPhotoEmpty of inputPhotoEmpty 
        |InputPhoto of inputPhoto 

    type inputVideoEmpty = 
        static member Constructor = 1426648181

    type inputVideo = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = -296249774

    type InputVideo = 
        |InputVideoEmpty of inputVideoEmpty 
        |InputVideo of inputVideo 

    type inputFileLocation = 
        {_volume_id : int64; _local_id : int; _secret : int64} with
        static member Constructor = 342061462

    type inputVideoFileLocation = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = 1023632620

    type inputEncryptedFileLocation = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = -182231723

    type inputAudioFileLocation = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = 1960591437

    type inputDocumentFileLocation = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = 1313188841

    type InputFileLocation = 
        |InputFileLocation of inputFileLocation 
        |InputVideoFileLocation of inputVideoFileLocation 
        |InputEncryptedFileLocation of inputEncryptedFileLocation 
        |InputAudioFileLocation of inputAudioFileLocation 
        |InputDocumentFileLocation of inputDocumentFileLocation 

    type inputPhotoCropAuto = 
        static member Constructor = -1377390588

    type inputPhotoCrop = 
        {_crop_left : double; _crop_top : double; _crop_width : double} with
        static member Constructor = -644787419

    type InputPhotoCrop = 
        |InputPhotoCropAuto of inputPhotoCropAuto 
        |InputPhotoCrop of inputPhotoCrop 

    type inputAppEvent = 
        {_time : double; _type : string; _peer : int64; _data : string} with
        static member Constructor = 1996904104

    type InputAppEvent = 
        |InputAppEvent of inputAppEvent 

    type peerUser = 
        {_user_id : int} with
        static member Constructor = -1649296275

    type peerChat = 
        {_chat_id : int} with
        static member Constructor = -1160714821

    type Peer = 
        |PeerUser of peerUser 
        |PeerChat of peerChat 

    type storage_fileUnknown = 
        static member Constructor = -1432995067

    type storage_filePartial = 
        static member Constructor = 1086091090

    type storage_fileJpeg = 
        static member Constructor = 8322574

    type storage_fileGif = 
        static member Constructor = -891180321

    type storage_filePng = 
        static member Constructor = 172975040

    type storage_filePdf = 
        static member Constructor = -1373745011

    type storage_fileMp3 = 
        static member Constructor = 1384777335

    type storage_fileMov = 
        static member Constructor = 1258941372

    type storage_fileMp4 = 
        static member Constructor = -1278304028

    type storage_fileWebp = 
        static member Constructor = 276907596

    type storage_FileType = 
        |Storage_fileUnknown of storage_fileUnknown 
        |Storage_filePartial of storage_filePartial 
        |Storage_fileJpeg of storage_fileJpeg 
        |Storage_fileGif of storage_fileGif 
        |Storage_filePng of storage_filePng 
        |Storage_filePdf of storage_filePdf 
        |Storage_fileMp3 of storage_fileMp3 
        |Storage_fileMov of storage_fileMov 
        |Storage_fileMp4 of storage_fileMp4 
        |Storage_fileWebp of storage_fileWebp 

    type fileLocationUnavailable = 
        {_volume_id : int64; _local_id : int; _secret : int64} with
        static member Constructor = 2086234950

    type fileLocation = 
        {_dc_id : int; _volume_id : int64; _local_id : int; _secret : int64} with
        static member Constructor = 1406570614

    type fileLocationUnavailable_23 = 
        {_volume_id : int64; _local_id : int; _secret : int64} with
        static member Constructor = 2086234950
        static member Layer = 23

    type fileLocation_23 = 
        {_dc_id : int; _volume_id : int64; _local_id : int; _secret : int64} with
        static member Constructor = 1406570614
        static member Layer = 23

    type FileLocation = 
        |FileLocationUnavailable of fileLocationUnavailable 
        |FileLocation of fileLocation 
        |FileLocationUnavailable_23 of fileLocationUnavailable_23 
        |FileLocation_23 of fileLocation_23 

    type userStatusEmpty = 
        static member Constructor = 164646985

    type userStatusOnline = 
        {_expires : int} with
        static member Constructor = -306628279

    type userStatusOffline = 
        {_was_online : int} with
        static member Constructor = 9203775

    type userStatusRecently = 
        static member Constructor = -496024847

    type userStatusLastWeek = 
        static member Constructor = 129960444

    type userStatusLastMonth = 
        static member Constructor = 2011940674

    type UserStatus = 
        |UserStatusEmpty of userStatusEmpty 
        |UserStatusOnline of userStatusOnline 
        |UserStatusOffline of userStatusOffline 
        |UserStatusRecently of userStatusRecently 
        |UserStatusLastWeek of userStatusLastWeek 
        |UserStatusLastMonth of userStatusLastMonth 

    type chatParticipant = 
        {_user_id : int; _inviter_id : int; _date : int} with
        static member Constructor = -925415106

    type ChatParticipant = 
        |ChatParticipant of chatParticipant 

    type geoPointEmpty = 
        static member Constructor = 286776671

    type geoPoint = 
        {_long : double; _lat : double} with
        static member Constructor = 541710092

    type GeoPoint = 
        |GeoPointEmpty of geoPointEmpty 
        |GeoPoint of geoPoint 

    type auth_exportedAuthorization = 
        {_id : int; _bytes : byte[]} with
        static member Constructor = -543777747

    type auth_ExportedAuthorization = 
        |Auth_exportedAuthorization of auth_exportedAuthorization 

    type inputPeerNotifyEventsEmpty = 
        static member Constructor = -265263912

    type inputPeerNotifyEventsAll = 
        static member Constructor = -395694988

    type InputPeerNotifyEvents = 
        |InputPeerNotifyEventsEmpty of inputPeerNotifyEventsEmpty 
        |InputPeerNotifyEventsAll of inputPeerNotifyEventsAll 

    type peerNotifyEventsEmpty = 
        static member Constructor = -1378534221

    type peerNotifyEventsAll = 
        static member Constructor = 1830677896

    type PeerNotifyEvents = 
        |PeerNotifyEventsEmpty of peerNotifyEventsEmpty 
        |PeerNotifyEventsAll of peerNotifyEventsAll 

    type peerSettings = 
        {_flags : int; _report_spam : bool} with
        static member Constructor = -2122045747

    type PeerSettings = 
        |PeerSettings of peerSettings 

    type inputReportReasonSpam = 
        static member Constructor = 1490799288

    type inputReportReasonViolence = 
        static member Constructor = 505595789

    type inputReportReasonPornography = 
        static member Constructor = 777640226

    type inputReportReasonOther = 
        {_text : string} with
        static member Constructor = -512463606

    type ReportReason = 
        |InputReportReasonSpam of inputReportReasonSpam 
        |InputReportReasonViolence of inputReportReasonViolence 
        |InputReportReasonPornography of inputReportReasonPornography 
        |InputReportReasonOther of inputReportReasonOther 

    type importedContact = 
        {_user_id : int; _client_id : int64} with
        static member Constructor = -805141448

    type ImportedContact = 
        |ImportedContact of importedContact 

    type contactBlocked = 
        {_user_id : int; _date : int} with
        static member Constructor = 1444661369

    type ContactBlocked = 
        |ContactBlocked of contactBlocked 

    type messages_affectedHistory = 
        {_pts : int; _seq : int; _offset : int} with
        static member Constructor = -1210173710

    type messages_AffectedHistory = 
        |Messages_affectedHistory of messages_affectedHistory 

    type inputMessagesFilterEmpty = 
        static member Constructor = 1474492012

    type inputMessagesFilterPhotos = 
        static member Constructor = -1777752804

    type inputMessagesFilterVideo = 
        static member Constructor = -1614803355

    type inputMessagesFilterPhotoVideo = 
        static member Constructor = 1458172132

    type inputMessagesFilterPhotoVideoDocuments = 
        static member Constructor = -648121413

    type inputMessagesFilterDocument = 
        static member Constructor = -1629621880

    type inputMessagesFilterAudio = 
        static member Constructor = -808946398

    type inputMessagesFilterAudioDocuments = 
        static member Constructor = 1526462308

    type inputMessagesFilterUrl = 
        static member Constructor = 2129714567

    type inputMessagesFilterGif = 
        static member Constructor = -3644025

    type MessagesFilter = 
        |InputMessagesFilterEmpty of inputMessagesFilterEmpty 
        |InputMessagesFilterPhotos of inputMessagesFilterPhotos 
        |InputMessagesFilterVideo of inputMessagesFilterVideo 
        |InputMessagesFilterPhotoVideo of inputMessagesFilterPhotoVideo 
        |InputMessagesFilterPhotoVideoDocuments of inputMessagesFilterPhotoVideoDocuments 
        |InputMessagesFilterDocument of inputMessagesFilterDocument 
        |InputMessagesFilterAudio of inputMessagesFilterAudio 
        |InputMessagesFilterAudioDocuments of inputMessagesFilterAudioDocuments 
        |InputMessagesFilterUrl of inputMessagesFilterUrl 
        |InputMessagesFilterGif of inputMessagesFilterGif 

    type updates_state = 
        {_pts : int; _qts : int; _date : int; _seq : int; _unread_count : int} with
        static member Constructor = -1519637954

    type updates_State = 
        |Updates_state of updates_state 

    type dcOption = 
        {_id : int; _hostname : string; _ip_address : string; _port : int} with
        static member Constructor = 784507964

    type DcOption = 
        |DcOption of dcOption 

    type nearestDc = 
        {_country : string; _this_dc : int; _nearest_dc : int} with
        static member Constructor = -1910892683

    type NearestDc = 
        |NearestDc of nearestDc 

    type help_inviteText = 
        {_message : string} with
        static member Constructor = 415997816

    type help_InviteText = 
        |Help_inviteText of help_inviteText 

    type encryptedChatEmpty = 
        {_id : int} with
        static member Constructor = -1417756512

    type encryptedChatWaiting = 
        {_id : int; _access_hash : int64; _date : int; _admin_id : int; _participant_id : int} with
        static member Constructor = 1006044124

    type encryptedChatRequested = 
        {_id : int; _access_hash : int64; _date : int; _admin_id : int; _participant_id : int; _g_a : byte[]} with
        static member Constructor = -931638658

    type encryptedChat = 
        {_id : int; _access_hash : int64; _date : int; _admin_id : int; _participant_id : int; _g_a_or_b : byte[]; _key_fingerprint : int64} with
        static member Constructor = -94974410

    type encryptedChatDiscarded = 
        {_id : int} with
        static member Constructor = 332848423

    type EncryptedChat = 
        |EncryptedChatEmpty of encryptedChatEmpty 
        |EncryptedChatWaiting of encryptedChatWaiting 
        |EncryptedChatRequested of encryptedChatRequested 
        |EncryptedChat of encryptedChat 
        |EncryptedChatDiscarded of encryptedChatDiscarded 

    type inputEncryptedChat = 
        {_chat_id : int; _access_hash : int64} with
        static member Constructor = -247351839

    type InputEncryptedChat = 
        |InputEncryptedChat of inputEncryptedChat 

    type encryptedFileEmpty = 
        static member Constructor = -1038136962

    type encryptedFile = 
        {_id : int64; _access_hash : int64; _size : int; _dc_id : int; _key_fingerprint : int} with
        static member Constructor = 1248893260

    type EncryptedFile = 
        |EncryptedFileEmpty of encryptedFileEmpty 
        |EncryptedFile of encryptedFile 

    type inputEncryptedFileEmpty = 
        static member Constructor = 406307684

    type inputEncryptedFileUploaded = 
        {_id : int64; _parts : int; _md5_checksum : string; _key_fingerprint : int} with
        static member Constructor = 1690108678

    type inputEncryptedFile = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = 1511503333

    type inputEncryptedFileBigUploaded = 
        {_id : int64; _parts : int; _key_fingerprint : int} with
        static member Constructor = 767652808

    type InputEncryptedFile = 
        |InputEncryptedFileEmpty of inputEncryptedFileEmpty 
        |InputEncryptedFileUploaded of inputEncryptedFileUploaded 
        |InputEncryptedFile of inputEncryptedFile 
        |InputEncryptedFileBigUploaded of inputEncryptedFileBigUploaded 

    type messages_dhConfigNotModified = 
        {_random : byte[]} with
        static member Constructor = -1058912715

    type messages_dhConfig = 
        {_g : int; _p : byte[]; _version : int; _random : byte[]} with
        static member Constructor = 740433629

    type messages_DhConfig = 
        |Messages_dhConfigNotModified of messages_dhConfigNotModified 
        |Messages_dhConfig of messages_dhConfig 

    type inputAudioEmpty = 
        static member Constructor = -648356732

    type inputAudio = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = 2010398975

    type InputAudio = 
        |InputAudioEmpty of inputAudioEmpty 
        |InputAudio of inputAudio 

    type inputDocumentEmpty = 
        static member Constructor = 1928391342

    type inputDocument = 
        {_id : int64; _access_hash : int64} with
        static member Constructor = 410618194

    type InputDocument = 
        |InputDocumentEmpty of inputDocumentEmpty 
        |InputDocument of inputDocument 

    type audioEmpty = 
        {_id : int64} with
        static member Constructor = 1483311320

    type audio = 
        {_id : int64; _access_hash : int64; _user_id : int; _date : int; _duration : int; _mime_type : string; _size : int; _dc_id : int} with
        static member Constructor = -945003370

    type Audio = 
        |AudioEmpty of audioEmpty 
        |Audio of audio 

    type sendMessageTypingAction = 
        static member Constructor = 381645902

    type sendMessageCancelAction = 
        static member Constructor = -44119819

    type sendMessageRecordVideoAction = 
        static member Constructor = -1584933265

    type sendMessageUploadVideoAction = 
        static member Constructor = -1845219337

    type sendMessageRecordAudioAction = 
        static member Constructor = -718310409

    type sendMessageUploadAudioAction = 
        static member Constructor = -424899985

    type sendMessageUploadPhotoAction = 
        static member Constructor = -1727382502

    type sendMessageUploadDocumentAction = 
        static member Constructor = -1884362354

    type sendMessageGeoLocationAction = 
        static member Constructor = 393186209

    type sendMessageChooseContactAction = 
        static member Constructor = 1653390447

    type sendMessageTypingAction_17 = 
        static member Constructor = 381645902
        static member Layer = 17

    type sendMessageCancelAction_17 = 
        static member Constructor = -44119819
        static member Layer = 17

    type sendMessageRecordVideoAction_17 = 
        static member Constructor = -1584933265
        static member Layer = 17

    type sendMessageUploadVideoAction_17 = 
        static member Constructor = -1845219337
        static member Layer = 17

    type sendMessageRecordAudioAction_17 = 
        static member Constructor = -718310409
        static member Layer = 17

    type sendMessageUploadAudioAction_17 = 
        static member Constructor = -424899985
        static member Layer = 17

    type sendMessageUploadPhotoAction_17 = 
        static member Constructor = -1727382502
        static member Layer = 17

    type sendMessageUploadDocumentAction_17 = 
        static member Constructor = -1884362354
        static member Layer = 17

    type sendMessageGeoLocationAction_17 = 
        static member Constructor = 393186209
        static member Layer = 17

    type sendMessageChooseContactAction_17 = 
        static member Constructor = 1653390447
        static member Layer = 17

    type SendMessageAction = 
        |SendMessageTypingAction of sendMessageTypingAction 
        |SendMessageCancelAction of sendMessageCancelAction 
        |SendMessageRecordVideoAction of sendMessageRecordVideoAction 
        |SendMessageUploadVideoAction of sendMessageUploadVideoAction 
        |SendMessageRecordAudioAction of sendMessageRecordAudioAction 
        |SendMessageUploadAudioAction of sendMessageUploadAudioAction 
        |SendMessageUploadPhotoAction of sendMessageUploadPhotoAction 
        |SendMessageUploadDocumentAction of sendMessageUploadDocumentAction 
        |SendMessageGeoLocationAction of sendMessageGeoLocationAction 
        |SendMessageChooseContactAction of sendMessageChooseContactAction 
        |SendMessageTypingAction_17 of sendMessageTypingAction_17 
        |SendMessageCancelAction_17 of sendMessageCancelAction_17 
        |SendMessageRecordVideoAction_17 of sendMessageRecordVideoAction_17 
        |SendMessageUploadVideoAction_17 of sendMessageUploadVideoAction_17 
        |SendMessageRecordAudioAction_17 of sendMessageRecordAudioAction_17 
        |SendMessageUploadAudioAction_17 of sendMessageUploadAudioAction_17 
        |SendMessageUploadPhotoAction_17 of sendMessageUploadPhotoAction_17 
        |SendMessageUploadDocumentAction_17 of sendMessageUploadDocumentAction_17 
        |SendMessageGeoLocationAction_17 of sendMessageGeoLocationAction_17 
        |SendMessageChooseContactAction_17 of sendMessageChooseContactAction_17 

    type contactFound = 
        {_user_id : int} with
        static member Constructor = -360210539

    type ContactFound = 
        |ContactFound of contactFound 

    type inputPrivacyKeyStatusTimestamp = 
        static member Constructor = 1335282456

    type InputPrivacyKey = 
        |InputPrivacyKeyStatusTimestamp of inputPrivacyKeyStatusTimestamp 

    type privacyKeyStatusTimestamp = 
        static member Constructor = -1137792208

    type PrivacyKey = 
        |PrivacyKeyStatusTimestamp of privacyKeyStatusTimestamp 

    type privacyValueAllowContacts = 
        static member Constructor = -123988

    type privacyValueAllowAll = 
        static member Constructor = 1698855810

    type privacyValueAllowUsers = 
        {_users : Vector<int>} with
        static member Constructor = 1297858060

    type privacyValueDisallowContacts = 
        static member Constructor = -125240806

    type privacyValueDisallowAll = 
        static member Constructor = -1955338397

    type privacyValueDisallowUsers = 
        {_users : Vector<int>} with
        static member Constructor = 209668535

    type PrivacyRule = 
        |PrivacyValueAllowContacts of privacyValueAllowContacts 
        |PrivacyValueAllowAll of privacyValueAllowAll 
        |PrivacyValueAllowUsers of privacyValueAllowUsers 
        |PrivacyValueDisallowContacts of privacyValueDisallowContacts 
        |PrivacyValueDisallowAll of privacyValueDisallowAll 
        |PrivacyValueDisallowUsers of privacyValueDisallowUsers 

    type accountDaysTTL = 
        {_days : int} with
        static member Constructor = -1194283041

    type AccountDaysTTL = 
        |AccountDaysTTL of accountDaysTTL 

    type account_sentChangePhoneCode = 
        {_phone_code_hash : string; _send_call_timeout : int} with
        static member Constructor = -1527411636

    type account_SentChangePhoneCode = 
        |Account_sentChangePhoneCode of account_sentChangePhoneCode 

    type documentAttributeImageSize = 
        {_w : int; _h : int} with
        static member Constructor = 1815593308

    type documentAttributeAnimated = 
        static member Constructor = 297109817

    type documentAttributeSticker = 
        static member Constructor = -83208409

    type documentAttributeVideo = 
        {_duration : int; _w : int; _h : int} with
        static member Constructor = 1494273227

    type documentAttributeAudio = 
        {_duration : int} with
        static member Constructor = 85215461

    type documentAttributeFilename = 
        {_file_name : string} with
        static member Constructor = 358154344

    type documentAttributeImageSize_23 = 
        {_w : int; _h : int} with
        static member Constructor = 1815593308
        static member Layer = 23

    type documentAttributeAnimated_23 = 
        static member Constructor = 297109817
        static member Layer = 23

    type documentAttributeSticker_23 = 
        static member Constructor = -83208409
        static member Layer = 23

    type documentAttributeVideo_23 = 
        {_duration : int; _w : int; _h : int} with
        static member Constructor = 1494273227
        static member Layer = 23

    type documentAttributeAudio_23 = 
        {_duration : int} with
        static member Constructor = 85215461
        static member Layer = 23

    type documentAttributeFilename_23 = 
        {_file_name : string} with
        static member Constructor = 358154344
        static member Layer = 23

    type DocumentAttribute = 
        |DocumentAttributeImageSize of documentAttributeImageSize 
        |DocumentAttributeAnimated of documentAttributeAnimated 
        |DocumentAttributeSticker of documentAttributeSticker 
        |DocumentAttributeVideo of documentAttributeVideo 
        |DocumentAttributeAudio of documentAttributeAudio 
        |DocumentAttributeFilename of documentAttributeFilename 
        |DocumentAttributeImageSize_23 of documentAttributeImageSize_23 
        |DocumentAttributeAnimated_23 of documentAttributeAnimated_23 
        |DocumentAttributeSticker_23 of documentAttributeSticker_23 
        |DocumentAttributeVideo_23 of documentAttributeVideo_23 
        |DocumentAttributeAudio_23 of documentAttributeAudio_23 
        |DocumentAttributeFilename_23 of documentAttributeFilename_23 

    type stickerPack = 
        {_emoticon : string; _documents : Vector<int64>} with
        static member Constructor = 313694676

    type StickerPack = 
        |StickerPack of stickerPack 

    type disabledFeature = 
        {_feature : string; _description : string} with
        static member Constructor = -1369215196

    type DisabledFeature = 
        |DisabledFeature of disabledFeature 

    type inputMediaEmpty = 
        static member Constructor = -1771768449

    type inputMediaUploadedPhoto = 
        {_file : InputFile} with
        static member Constructor = 767900285

    type inputMediaPhoto = 
        {_id : InputPhoto} with
        static member Constructor = -1893027092

    type inputMediaGeoPoint = 
        {_geo_point : InputGeoPoint} with
        static member Constructor = -104578748

    type inputMediaContact = 
        {_phone_number : string; _first_name : string; _last_name : string} with
        static member Constructor = -1494984313

    type inputMediaUploadedVideo = 
        {_file : InputFile; _duration : int; _w : int; _h : int; _mime_type : string} with
        static member Constructor = 322623222

    type inputMediaUploadedThumbVideo = 
        {_file : InputFile; _thumb : InputFile; _duration : int; _w : int; _h : int; _mime_type : string} with
        static member Constructor = -1726817601

    type inputMediaVideo = 
        {_id : InputVideo} with
        static member Constructor = 2130852582

    type inputMediaUploadedAudio = 
        {_file : InputFile; _duration : int; _mime_type : string} with
        static member Constructor = 1313442987

    type inputMediaAudio = 
        {_id : InputAudio} with
        static member Constructor = -1986820223

    type inputMediaUploadedDocument = 
        {_file : InputFile; _mime_type : string; _attributes : Vector<DocumentAttribute>} with
        static member Constructor = -1610888

    type inputMediaUploadedThumbDocument = 
        {_file : InputFile; _thumb : InputFile; _mime_type : string; _attributes : Vector<DocumentAttribute>} with
        static member Constructor = 1095242886

    type inputMediaDocument = 
        {_id : InputDocument} with
        static member Constructor = -779818943

    type InputMedia = 
        |InputMediaEmpty of inputMediaEmpty 
        |InputMediaUploadedPhoto of inputMediaUploadedPhoto 
        |InputMediaPhoto of inputMediaPhoto 
        |InputMediaGeoPoint of inputMediaGeoPoint 
        |InputMediaContact of inputMediaContact 
        |InputMediaUploadedVideo of inputMediaUploadedVideo 
        |InputMediaUploadedThumbVideo of inputMediaUploadedThumbVideo 
        |InputMediaVideo of inputMediaVideo 
        |InputMediaUploadedAudio of inputMediaUploadedAudio 
        |InputMediaAudio of inputMediaAudio 
        |InputMediaUploadedDocument of inputMediaUploadedDocument 
        |InputMediaUploadedThumbDocument of inputMediaUploadedThumbDocument 
        |InputMediaDocument of inputMediaDocument 

    type inputChatPhotoEmpty = 
        static member Constructor = 480546647

    type inputChatUploadedPhoto = 
        {_file : InputFile; _crop : InputPhotoCrop} with
        static member Constructor = -1809496270

    type inputChatPhoto = 
        {_id : InputPhoto; _crop : InputPhotoCrop} with
        static member Constructor = -1293828344

    type InputChatPhoto = 
        |InputChatPhotoEmpty of inputChatPhotoEmpty 
        |InputChatUploadedPhoto of inputChatUploadedPhoto 
        |InputChatPhoto of inputChatPhoto 

    type userProfilePhotoEmpty = 
        static member Constructor = 1326562017

    type userProfilePhoto = 
        {_photo_id : int64; _photo_small : FileLocation; _photo_big : FileLocation} with
        static member Constructor = -715532088

    type UserProfilePhoto = 
        |UserProfilePhotoEmpty of userProfilePhotoEmpty 
        |UserProfilePhoto of userProfilePhoto 

    type chatParticipantsForbidden = 
        {_chat_id : int} with
        static member Constructor = 265468810

    type chatParticipants = 
        {_chat_id : int; _admin_id : int; _participants : Vector<ChatParticipant>; _version : int} with
        static member Constructor = 2017571861

    type ChatParticipants = 
        |ChatParticipantsForbidden of chatParticipantsForbidden 
        |ChatParticipants of chatParticipants 

    type chatPhotoEmpty = 
        static member Constructor = 935395612

    type chatPhoto = 
        {_photo_small : FileLocation; _photo_big : FileLocation} with
        static member Constructor = 1632839530

    type ChatPhoto = 
        |ChatPhotoEmpty of chatPhotoEmpty 
        |ChatPhoto of chatPhoto 

    type photoSizeEmpty = 
        {_type : string} with
        static member Constructor = 236446268

    type photoSize = 
        {_type : string; _location : FileLocation; _w : int; _h : int; _size : int} with
        static member Constructor = 2009052699

    type photoCachedSize = 
        {_type : string; _location : FileLocation; _w : int; _h : int; _bytes : byte[]} with
        static member Constructor = -374917894

    type photoSizeEmpty_23 = 
        {_type : string} with
        static member Constructor = 236446268
        static member Layer = 23

    type photoSize_23 = 
        {_type : string; _location : FileLocation; _w : int; _h : int; _size : int} with
        static member Constructor = 2009052699
        static member Layer = 23

    type photoCachedSize_23 = 
        {_type : string; _location : FileLocation; _w : int; _h : int; _bytes : byte[]} with
        static member Constructor = -374917894
        static member Layer = 23

    type PhotoSize = 
        |PhotoSizeEmpty of photoSizeEmpty 
        |PhotoSize of photoSize 
        |PhotoCachedSize of photoCachedSize 
        |PhotoSizeEmpty_23 of photoSizeEmpty_23 
        |PhotoSize_23 of photoSize_23 
        |PhotoCachedSize_23 of photoCachedSize_23 

    type auth_checkedPhone = 
        {_phone_registered : Bool; _phone_invited : Bool} with
        static member Constructor = -486486981

    type auth_CheckedPhone = 
        |Auth_checkedPhone of auth_checkedPhone 

    type auth_sentCode = 
        {_phone_registered : Bool; _phone_code_hash : string; _send_call_timeout : int; _is_password : Bool} with
        static member Constructor = -269659687

    type auth_sentAppCode = 
        {_phone_registered : Bool; _phone_code_hash : string; _send_call_timeout : int; _is_password : Bool} with
        static member Constructor = -484053553

    type auth_SentCode = 
        |Auth_sentCode of auth_sentCode 
        |Auth_sentAppCode of auth_sentAppCode 

    type inputNotifyPeer = 
        {_peer : InputPeer} with
        static member Constructor = -1195615476

    type inputNotifyUsers = 
        static member Constructor = 423314455

    type inputNotifyChats = 
        static member Constructor = 1251338318

    type inputNotifyAll = 
        static member Constructor = -1540769658

    type InputNotifyPeer = 
        |InputNotifyPeer of inputNotifyPeer 
        |InputNotifyUsers of inputNotifyUsers 
        |InputNotifyChats of inputNotifyChats 
        |InputNotifyAll of inputNotifyAll 

    type inputPeerNotifySettings = 
        {_mute_until : int; _sound : string; _show_previews : Bool; _events_mask : int} with
        static member Constructor = 1185074840

    type InputPeerNotifySettings = 
        |InputPeerNotifySettings of inputPeerNotifySettings 

    type peerNotifySettingsEmpty = 
        static member Constructor = 1889961234

    type peerNotifySettings = 
        {_mute_until : int; _sound : string; _show_previews : Bool; _events_mask : int} with
        static member Constructor = -1923214866

    type PeerNotifySettings = 
        |PeerNotifySettingsEmpty of peerNotifySettingsEmpty 
        |PeerNotifySettings of peerNotifySettings 

    type contact = 
        {_user_id : int; _mutual : Bool} with
        static member Constructor = -116274796

    type Contact = 
        |Contact of contact 

    type contactStatus = 
        {_user_id : int; _status : UserStatus} with
        static member Constructor = -748155807

    type ContactStatus = 
        |ContactStatus of contactStatus 

    type contacts_foreignLinkUnknown = 
        static member Constructor = 322183672

    type contacts_foreignLinkRequested = 
        {_has_phone : Bool} with
        static member Constructor = -1484775609

    type contacts_foreignLinkMutual = 
        static member Constructor = 468356321

    type contacts_ForeignLink = 
        |Contacts_foreignLinkUnknown of contacts_foreignLinkUnknown 
        |Contacts_foreignLinkRequested of contacts_foreignLinkRequested 
        |Contacts_foreignLinkMutual of contacts_foreignLinkMutual 

    type contacts_myLinkEmpty = 
        static member Constructor = -768992160

    type contacts_myLinkRequested = 
        {_contact : Bool} with
        static member Constructor = 1818882030

    type contacts_myLinkContact = 
        static member Constructor = -1035932711

    type contacts_MyLink = 
        |Contacts_myLinkEmpty of contacts_myLinkEmpty 
        |Contacts_myLinkRequested of contacts_myLinkRequested 
        |Contacts_myLinkContact of contacts_myLinkContact 

    type upload_file = 
        {_type : storage_FileType; _mtime : int; _bytes : byte[]} with
        static member Constructor = 157948117

    type upload_File = 
        |Upload_file of upload_file 

    type config = 
        {_date : int; _expires : int; _test_mode : Bool; _this_dc : int; _dc_options : Vector<DcOption>; _chat_big_size : int; _chat_size_max : int; _broadcast_size_max : int; _disabled_features : Vector<DisabledFeature>} with
        static member Constructor = 2108568544

    type Config = 
        |Config of config 

    type help_appUpdate = 
        {_id : int; _critical : Bool; _url : string; _text : string} with
        static member Constructor = -1987579119

    type help_noAppUpdate = 
        static member Constructor = -1000708810

    type help_AppUpdate = 
        |Help_appUpdate of help_appUpdate 
        |Help_noAppUpdate of help_noAppUpdate 

    type encryptedMessage = 
        {_random_id : int64; _chat_id : int; _date : int; _bytes : byte[]; _file : EncryptedFile} with
        static member Constructor = -317144808

    type encryptedMessageService = 
        {_random_id : int64; _chat_id : int; _date : int; _bytes : byte[]} with
        static member Constructor = 594758406

    type EncryptedMessage = 
        |EncryptedMessage of encryptedMessage 
        |EncryptedMessageService of encryptedMessageService 

    type messages_sentEncryptedMessage = 
        {_date : int} with
        static member Constructor = 1443858741

    type messages_sentEncryptedFile = 
        {_date : int; _file : EncryptedFile} with
        static member Constructor = -1802240206

    type messages_SentEncryptedMessage = 
        |Messages_sentEncryptedMessage of messages_sentEncryptedMessage 
        |Messages_sentEncryptedFile of messages_sentEncryptedFile 

    type notifyPeer = 
        {_peer : Peer} with
        static member Constructor = -1613493288

    type notifyUsers = 
        static member Constructor = -1261946036

    type notifyChats = 
        static member Constructor = -1073230141

    type notifyAll = 
        static member Constructor = 1959820384

    type NotifyPeer = 
        |NotifyPeer of notifyPeer 
        |NotifyUsers of notifyUsers 
        |NotifyChats of notifyChats 
        |NotifyAll of notifyAll 

    type inputPrivacyValueAllowContacts = 
        static member Constructor = 218751099

    type inputPrivacyValueAllowAll = 
        static member Constructor = 407582158

    type inputPrivacyValueAllowUsers = 
        {_users : Vector<InputUser>} with
        static member Constructor = 320652927

    type inputPrivacyValueDisallowContacts = 
        static member Constructor = 195371015

    type inputPrivacyValueDisallowAll = 
        static member Constructor = -697604407

    type inputPrivacyValueDisallowUsers = 
        {_users : Vector<InputUser>} with
        static member Constructor = -1877932953

    type InputPrivacyRule = 
        |InputPrivacyValueAllowContacts of inputPrivacyValueAllowContacts 
        |InputPrivacyValueAllowAll of inputPrivacyValueAllowAll 
        |InputPrivacyValueAllowUsers of inputPrivacyValueAllowUsers 
        |InputPrivacyValueDisallowContacts of inputPrivacyValueDisallowContacts 
        |InputPrivacyValueDisallowAll of inputPrivacyValueDisallowAll 
        |InputPrivacyValueDisallowUsers of inputPrivacyValueDisallowUsers 

    type decryptedMessageActionSetMessageTTL_8 = 
        {_ttl_seconds : int} with
        static member Constructor = -1586283796
        static member Layer = 8

    type decryptedMessageActionReadMessages_8 = 
        {_random_ids : Vector<int64>} with
        static member Constructor = 206520510
        static member Layer = 8

    type decryptedMessageActionDeleteMessages_8 = 
        {_random_ids : Vector<int64>} with
        static member Constructor = 1700872964
        static member Layer = 8

    type decryptedMessageActionScreenshotMessages_8 = 
        {_random_ids : Vector<int64>} with
        static member Constructor = -1967000459
        static member Layer = 8

    type decryptedMessageActionFlushHistory_8 = 
        static member Constructor = 1729750108
        static member Layer = 8

    type decryptedMessageActionResend_17 = 
        {_start_seq_no : int; _end_seq_no : int} with
        static member Constructor = 1360072880
        static member Layer = 17

    type decryptedMessageActionNotifyLayer_17 = 
        {_layer : int} with
        static member Constructor = -217806717
        static member Layer = 17

    type decryptedMessageActionTyping_17 = 
        {_action : SendMessageAction} with
        static member Constructor = -860719551
        static member Layer = 17

    type decryptedMessageActionRequestKey_20 = 
        {_exchange_id : int64; _g_a : byte[]} with
        static member Constructor = -204906213
        static member Layer = 20

    type decryptedMessageActionAcceptKey_20 = 
        {_exchange_id : int64; _g_b : byte[]; _key_fingerprint : int64} with
        static member Constructor = 1877046107
        static member Layer = 20

    type decryptedMessageActionAbortKey_20 = 
        {_exchange_id : int64} with
        static member Constructor = -586814357
        static member Layer = 20

    type decryptedMessageActionCommitKey_20 = 
        {_exchange_id : int64; _key_fingerprint : int64} with
        static member Constructor = -332526693
        static member Layer = 20

    type decryptedMessageActionNoop_20 = 
        static member Constructor = -1473258141
        static member Layer = 20

    type DecryptedMessageAction = 
        |DecryptedMessageActionSetMessageTTL_8 of decryptedMessageActionSetMessageTTL_8 
        |DecryptedMessageActionReadMessages_8 of decryptedMessageActionReadMessages_8 
        |DecryptedMessageActionDeleteMessages_8 of decryptedMessageActionDeleteMessages_8 
        |DecryptedMessageActionScreenshotMessages_8 of decryptedMessageActionScreenshotMessages_8 
        |DecryptedMessageActionFlushHistory_8 of decryptedMessageActionFlushHistory_8 
        |DecryptedMessageActionResend_17 of decryptedMessageActionResend_17 
        |DecryptedMessageActionNotifyLayer_17 of decryptedMessageActionNotifyLayer_17 
        |DecryptedMessageActionTyping_17 of decryptedMessageActionTyping_17 
        |DecryptedMessageActionRequestKey_20 of decryptedMessageActionRequestKey_20 
        |DecryptedMessageActionAcceptKey_20 of decryptedMessageActionAcceptKey_20 
        |DecryptedMessageActionAbortKey_20 of decryptedMessageActionAbortKey_20 
        |DecryptedMessageActionCommitKey_20 of decryptedMessageActionCommitKey_20 
        |DecryptedMessageActionNoop_20 of decryptedMessageActionNoop_20 

    type userEmpty = 
        {_id : int} with
        static member Constructor = 537022650

    type userSelf = 
        {_id : int; _first_name : string; _last_name : string; _username : string; _phone : string; _photo : UserProfilePhoto; _status : UserStatus; _inactive : Bool} with
        static member Constructor = 1879553105

    type userContact = 
        {_id : int; _first_name : string; _last_name : string; _username : string; _access_hash : int64; _phone : string; _photo : UserProfilePhoto; _status : UserStatus} with
        static member Constructor = -894214632

    type userRequest = 
        {_id : int; _first_name : string; _last_name : string; _username : string; _access_hash : int64; _phone : string; _photo : UserProfilePhoto; _status : UserStatus} with
        static member Constructor = -640891665

    type userForeign = 
        {_id : int; _first_name : string; _last_name : string; _username : string; _access_hash : int64; _photo : UserProfilePhoto; _status : UserStatus} with
        static member Constructor = 123533224

    type userDeleted = 
        {_id : int; _first_name : string; _last_name : string; _username : string} with
        static member Constructor = -704549510

    type User = 
        |UserEmpty of userEmpty 
        |UserSelf of userSelf 
        |UserContact of userContact 
        |UserRequest of userRequest 
        |UserForeign of userForeign 
        |UserDeleted of userDeleted 

    type chatEmpty = 
        {_id : int} with
        static member Constructor = -1683826688

    type chat = 
        {_id : int; _title : string; _photo : ChatPhoto; _participants_count : int; _date : int; _left : Bool; _version : int} with
        static member Constructor = 1855757255

    type chatForbidden = 
        {_id : int; _title : string; _date : int} with
        static member Constructor = -83047359

    type Chat = 
        |ChatEmpty of chatEmpty 
        |Chat of chat 
        |ChatForbidden of chatForbidden 

    type dialog = 
        {_peer : Peer; _top_message : int; _unread_count : int; _notify_settings : PeerNotifySettings} with
        static member Constructor = -1422222932

    type Dialog = 
        |Dialog of dialog 

    type photoEmpty = 
        {_id : int64} with
        static member Constructor = 590459437

    type photo = 
        {_id : int64; _access_hash : int64; _user_id : int; _date : int; _caption : string; _geo : GeoPoint; _sizes : Vector<PhotoSize>} with
        static member Constructor = 582313809

    type Photo = 
        |PhotoEmpty of photoEmpty 
        |Photo of photo 

    type videoEmpty = 
        {_id : int64} with
        static member Constructor = -1056548696

    type video = 
        {_id : int64; _access_hash : int64; _user_id : int; _date : int; _caption : string; _duration : int; _mime_type : string; _size : int; _thumb : PhotoSize; _dc_id : int; _w : int; _h : int} with
        static member Constructor = 948937617

    type Video = 
        |VideoEmpty of videoEmpty 
        |Video of video 

    type wallPaper = 
        {_id : int; _title : string; _sizes : Vector<PhotoSize>; _color : int} with
        static member Constructor = -860866985

    type wallPaperSolid = 
        {_id : int; _title : string; _bg_color : int; _color : int} with
        static member Constructor = 1662091044

    type WallPaper = 
        |WallPaper of wallPaper 
        |WallPaperSolid of wallPaperSolid 

    type documentEmpty = 
        {_id : int64} with
        static member Constructor = 922273905

    type document = 
        {_id : int64; _access_hash : int64; _date : int; _mime_type : string; _size : int; _thumb : PhotoSize; _dc_id : int; _attributes : Vector<DocumentAttribute>} with
        static member Constructor = -106717361

    type Document = 
        |DocumentEmpty of documentEmpty 
        |Document of document 

    type decryptedMessageMediaEmpty_8 = 
        static member Constructor = 144661578
        static member Layer = 8

    type decryptedMessageMediaPhoto_8 = 
        {_thumb : byte[]; _thumb_w : int; _thumb_h : int; _w : int; _h : int; _size : int; _key : byte[]; _iv : byte[]} with
        static member Constructor = 846826124
        static member Layer = 8

    type decryptedMessageMediaVideo_8 = 
        {_thumb : byte[]; _thumb_w : int; _thumb_h : int; _duration : int; _w : int; _h : int; _size : int; _key : byte[]; _iv : byte[]} with
        static member Constructor = 1290694387
        static member Layer = 8

    type decryptedMessageMediaVideo_17 = 
        {_thumb : byte[]; _thumb_w : int; _thumb_h : int; _duration : int; _mime_type : string; _w : int; _h : int; _size : int; _key : byte[]; _iv : byte[]} with
        static member Constructor = 1380598109
        static member Layer = 17

    type decryptedMessageMediaGeoPoint_8 = 
        {_lat : double; _long : double} with
        static member Constructor = 893913689
        static member Layer = 8

    type decryptedMessageMediaContact_8 = 
        {_phone_number : string; _first_name : string; _last_name : string; _user_id : int} with
        static member Constructor = 1485441687
        static member Layer = 8

    type decryptedMessageMediaDocument_8 = 
        {_thumb : byte[]; _thumb_w : int; _thumb_h : int; _file_name : string; _mime_type : string; _size : int; _key : byte[]; _iv : byte[]} with
        static member Constructor = -1332395189
        static member Layer = 8

    type decryptedMessageMediaAudio_8 = 
        {_duration : int; _size : int; _key : byte[]; _iv : byte[]} with
        static member Constructor = 1619031439
        static member Layer = 8

    type decryptedMessageMediaAudio_17 = 
        {_duration : int; _mime_type : string; _size : int; _key : byte[]; _iv : byte[]} with
        static member Constructor = 1474341323
        static member Layer = 17

    type decryptedMessageMediaExternalDocument_23 = 
        {_id : int64; _access_hash : int64; _date : int; _mime_type : string; _size : int; _thumb : PhotoSize; _dc_id : int; _attributes : Vector<DocumentAttribute>} with
        static member Constructor = -90853155
        static member Layer = 23

    type DecryptedMessageMedia = 
        |DecryptedMessageMediaEmpty_8 of decryptedMessageMediaEmpty_8 
        |DecryptedMessageMediaPhoto_8 of decryptedMessageMediaPhoto_8 
        |DecryptedMessageMediaVideo_8 of decryptedMessageMediaVideo_8 
        |DecryptedMessageMediaVideo_17 of decryptedMessageMediaVideo_17 
        |DecryptedMessageMediaGeoPoint_8 of decryptedMessageMediaGeoPoint_8 
        |DecryptedMessageMediaContact_8 of decryptedMessageMediaContact_8 
        |DecryptedMessageMediaDocument_8 of decryptedMessageMediaDocument_8 
        |DecryptedMessageMediaAudio_8 of decryptedMessageMediaAudio_8 
        |DecryptedMessageMediaAudio_17 of decryptedMessageMediaAudio_17 
        |DecryptedMessageMediaExternalDocument_23 of decryptedMessageMediaExternalDocument_23 

    type chatFull = 
        {_id : int; _participants : ChatParticipants; _chat_photo : Photo; _notify_settings : PeerNotifySettings} with
        static member Constructor = 1661886910

    type ChatFull = 
        |ChatFull of chatFull 

    type messageMediaEmpty = 
        static member Constructor = 1038967584

    type messageMediaPhoto = 
        {_photo : Photo} with
        static member Constructor = -926655958

    type messageMediaVideo = 
        {_video : Video} with
        static member Constructor = -1563278704

    type messageMediaGeo = 
        {_geo : GeoPoint} with
        static member Constructor = 1457575028

    type messageMediaContact = 
        {_phone_number : string; _first_name : string; _last_name : string; _user_id : int} with
        static member Constructor = 1585262393

    type messageMediaDocument = 
        {_document : Document} with
        static member Constructor = 802824708

    type messageMediaAudio = 
        {_audio : Audio} with
        static member Constructor = -961117440

    type MessageMedia = 
        |MessageMediaEmpty of messageMediaEmpty 
        |MessageMediaPhoto of messageMediaPhoto 
        |MessageMediaVideo of messageMediaVideo 
        |MessageMediaGeo of messageMediaGeo 
        |MessageMediaContact of messageMediaContact 
        |MessageMediaDocument of messageMediaDocument 
        |MessageMediaAudio of messageMediaAudio 

    type messageActionEmpty = 
        static member Constructor = -1230047312

    type messageActionChatCreate = 
        {_title : string; _users : Vector<int>} with
        static member Constructor = -1503425638

    type messageActionChatEditTitle = 
        {_title : string} with
        static member Constructor = -1247687078

    type messageActionChatEditPhoto = 
        {_photo : Photo} with
        static member Constructor = 2144015272

    type messageActionChatDeletePhoto = 
        static member Constructor = -1780220945

    type messageActionChatAddUser = 
        {_user_id : int} with
        static member Constructor = 1581055051

    type messageActionChatDeleteUser = 
        {_user_id : int} with
        static member Constructor = -1297179892

    type MessageAction = 
        |MessageActionEmpty of messageActionEmpty 
        |MessageActionChatCreate of messageActionChatCreate 
        |MessageActionChatEditTitle of messageActionChatEditTitle 
        |MessageActionChatEditPhoto of messageActionChatEditPhoto 
        |MessageActionChatDeletePhoto of messageActionChatDeletePhoto 
        |MessageActionChatAddUser of messageActionChatAddUser 
        |MessageActionChatDeleteUser of messageActionChatDeleteUser 

    type auth_authorization = 
        {_expires : int; _user : User} with
        static member Constructor = -155815004

    type auth_Authorization = 
        |Auth_authorization of auth_authorization 

    type contacts_link = 
        {_my_link : contacts_MyLink; _foreign_link : contacts_ForeignLink; _user : User} with
        static member Constructor = -322001931

    type contacts_Link = 
        |Contacts_link of contacts_link 

    type contacts_contactsNotModified = 
        static member Constructor = -1219778094

    type contacts_contacts = 
        {_contacts : Vector<Contact>; _users : Vector<User>} with
        static member Constructor = 1871416498

    type contacts_Contacts = 
        |Contacts_contactsNotModified of contacts_contactsNotModified 
        |Contacts_contacts of contacts_contacts 

    type contacts_importedContacts = 
        {_imported : Vector<ImportedContact>; _retry_contacts : Vector<int64>; _users : Vector<User>} with
        static member Constructor = -1387117803

    type contacts_ImportedContacts = 
        |Contacts_importedContacts of contacts_importedContacts 

    type contacts_blocked = 
        {_blocked : Vector<ContactBlocked>; _users : Vector<User>} with
        static member Constructor = 471043349

    type contacts_blockedSlice = 
        {_count : int; _blocked : Vector<ContactBlocked>; _users : Vector<User>} with
        static member Constructor = -1878523231

    type contacts_Blocked = 
        |Contacts_blocked of contacts_blocked 
        |Contacts_blockedSlice of contacts_blockedSlice 

    type messages_chats = 
        {_chats : Vector<Chat>; _users : Vector<User>} with
        static member Constructor = -2125411368

    type messages_Chats = 
        |Messages_chats of messages_chats 

    type photos_photos = 
        {_photos : Vector<Photo>; _users : Vector<User>} with
        static member Constructor = -1916114267

    type photos_photosSlice = 
        {_count : int; _photos : Vector<Photo>; _users : Vector<User>} with
        static member Constructor = 352657236

    type photos_Photos = 
        |Photos_photos of photos_photos 
        |Photos_photosSlice of photos_photosSlice 

    type photos_photo = 
        {_photo : Photo; _users : Vector<User>} with
        static member Constructor = 539045032

    type photos_Photo = 
        |Photos_photo of photos_photo 

    type help_support = 
        {_phone_number : string; _user : User} with
        static member Constructor = 398898678

    type help_Support = 
        |Help_support of help_support 

    type contacts_found = 
        {_results : Vector<ContactFound>; _users : Vector<User>} with
        static member Constructor = 90570766

    type contacts_Found = 
        |Contacts_found of contacts_found 

    type account_privacyRules = 
        {_rules : Vector<PrivacyRule>; _users : Vector<User>} with
        static member Constructor = 1430961007

    type account_PrivacyRules = 
        |Account_privacyRules of account_privacyRules 

    type messages_stickersNotModified = 
        static member Constructor = -244016606

    type messages_stickers = 
        {_hash : string; _stickers : Vector<Document>} with
        static member Constructor = -1970352846

    type messages_Stickers = 
        |Messages_stickersNotModified of messages_stickersNotModified 
        |Messages_stickers of messages_stickers 

    type messages_allStickersNotModified = 
        static member Constructor = -395967805

    type messages_allStickers = 
        {_hash : string; _packs : Vector<StickerPack>; _documents : Vector<Document>} with
        static member Constructor = -588304126

    type messages_AllStickers = 
        |Messages_allStickersNotModified of messages_allStickersNotModified 
        |Messages_allStickers of messages_allStickers 

    type decryptedMessage_8 = 
        {_random_id : int64; _random_bytes : byte[]; _message : string; _media : DecryptedMessageMedia} with
        static member Constructor = 528568095
        static member Layer = 8

    type decryptedMessage_17 = 
        {_random_id : int64; _ttl : int; _message : string; _media : DecryptedMessageMedia} with
        static member Constructor = 541931640
        static member Layer = 17

    type decryptedMessageService_8 = 
        {_random_id : int64; _random_bytes : byte[]; _action : DecryptedMessageAction} with
        static member Constructor = -1438109059
        static member Layer = 8

    type decryptedMessageService_17 = 
        {_random_id : int64; _action : DecryptedMessageAction} with
        static member Constructor = 1930838368
        static member Layer = 17

    type DecryptedMessage = 
        |DecryptedMessage_8 of decryptedMessage_8 
        |DecryptedMessage_17 of decryptedMessage_17 
        |DecryptedMessageService_8 of decryptedMessageService_8 
        |DecryptedMessageService_17 of decryptedMessageService_17 

    type messageEmpty = 
        {_id : int} with
        static member Constructor = -2082087340

    type message = 
        {_flags : int; _id : int; _from_id : int; _to_id : Peer; _date : int; _message : string; _media : MessageMedia} with
        static member Constructor = 1450613171

    type messageForwarded = 
        {_flags : int; _id : int; _fwd_from_id : int; _fwd_date : int; _from_id : int; _to_id : Peer; _date : int; _message : string; _media : MessageMedia} with
        static member Constructor = -1553471722

    type messageService = 
        {_flags : int; _id : int; _from_id : int; _to_id : Peer; _date : int; _action : MessageAction} with
        static member Constructor = 495384334

    type Message = 
        |MessageEmpty of messageEmpty 
        |Message of message 
        |MessageForwarded of messageForwarded 
        |MessageService of messageService 

    type userFull = 
        {_user : User; _link : contacts_Link; _profile_photo : Photo; _notify_settings : PeerNotifySettings; _blocked : Bool; _real_first_name : string; _real_last_name : string} with
        static member Constructor = 1997575642

    type UserFull = 
        |UserFull of userFull 

    type messages_sentMessage = 
        {_id : int; _date : int; _pts : int; _seq : int} with
        static member Constructor = -772484260

    type messages_sentMessageLink = 
        {_id : int; _date : int; _pts : int; _seq : int; _links : Vector<contacts_Link>} with
        static member Constructor = -371504577

    type messages_SentMessage = 
        |Messages_sentMessage of messages_sentMessage 
        |Messages_sentMessageLink of messages_sentMessageLink 

    type messages_chatFull = 
        {_full_chat : ChatFull; _chats : Vector<Chat>; _users : Vector<User>} with
        static member Constructor = -438840932

    type messages_ChatFull = 
        |Messages_chatFull of messages_chatFull 

    type decryptedMessageLayer_17 = 
        {_random_bytes : byte[]; _layer : int; _in_seq_no : int; _out_seq_no : int; _message : DecryptedMessage} with
        static member Constructor = 467867529
        static member Layer = 17

    type DecryptedMessageLayer = 
        |DecryptedMessageLayer_17 of decryptedMessageLayer_17 

    type messages_dialogs = 
        {_dialogs : Vector<Dialog>; _messages : Vector<Message>; _chats : Vector<Chat>; _users : Vector<User>} with
        static member Constructor = 364538944

    type messages_dialogsSlice = 
        {_count : int; _dialogs : Vector<Dialog>; _messages : Vector<Message>; _chats : Vector<Chat>; _users : Vector<User>} with
        static member Constructor = 1910543603

    type messages_Dialogs = 
        |Messages_dialogs of messages_dialogs 
        |Messages_dialogsSlice of messages_dialogsSlice 

    type messages_messages = 
        {_messages : Vector<Message>; _chats : Vector<Chat>; _users : Vector<User>} with
        static member Constructor = -1938715001

    type messages_messagesSlice = 
        {_count : int; _messages : Vector<Message>; _chats : Vector<Chat>; _users : Vector<User>} with
        static member Constructor = 189033187

    type messages_Messages = 
        |Messages_messages of messages_messages 
        |Messages_messagesSlice of messages_messagesSlice 

    type messages_statedMessages = 
        {_messages : Vector<Message>; _chats : Vector<Chat>; _users : Vector<User>; _pts : int; _seq : int} with
        static member Constructor = -1768654661

    type messages_statedMessagesLinks = 
        {_messages : Vector<Message>; _chats : Vector<Chat>; _users : Vector<User>; _links : Vector<contacts_Link>; _pts : int; _seq : int} with
        static member Constructor = 1047852486

    type messages_StatedMessages = 
        |Messages_statedMessages of messages_statedMessages 
        |Messages_statedMessagesLinks of messages_statedMessagesLinks 

    type messages_statedMessage = 
        {_message : Message; _chats : Vector<Chat>; _users : Vector<User>; _pts : int; _seq : int} with
        static member Constructor = -797251802

    type messages_statedMessageLink = 
        {_message : Message; _chats : Vector<Chat>; _users : Vector<User>; _links : Vector<contacts_Link>; _pts : int; _seq : int} with
        static member Constructor = -1448138623

    type messages_StatedMessage = 
        |Messages_statedMessage of messages_statedMessage 
        |Messages_statedMessageLink of messages_statedMessageLink 

    type updateNewMessage = 
        {_message : Message; _pts : int} with
        static member Constructor = 20626867

    type updateMessageID = 
        {_id : int; _random_id : int64} with
        static member Constructor = 1318109142

    type updateReadMessages = 
        {_messages : Vector<int>; _pts : int} with
        static member Constructor = -966484431

    type updateDeleteMessages = 
        {_messages : Vector<int>; _pts : int} with
        static member Constructor = -1456734682

    type updateUserTyping = 
        {_user_id : int; _action : SendMessageAction} with
        static member Constructor = 1548249383

    type updateChatUserTyping = 
        {_chat_id : int; _user_id : int; _action : SendMessageAction} with
        static member Constructor = -1704596961

    type updateChatParticipants = 
        {_participants : ChatParticipants} with
        static member Constructor = 125178264

    type updateUserStatus = 
        {_user_id : int; _status : UserStatus} with
        static member Constructor = 469489699

    type updateUserName = 
        {_user_id : int; _first_name : string; _last_name : string; _username : string} with
        static member Constructor = -1489818765

    type updateUserPhoto = 
        {_user_id : int; _date : int; _photo : UserProfilePhoto; _previous : Bool} with
        static member Constructor = -1791935732

    type updateContactRegistered = 
        {_user_id : int; _date : int} with
        static member Constructor = 628472761

    type updateContactLink = 
        {_user_id : int; _my_link : contacts_MyLink; _foreign_link : contacts_ForeignLink} with
        static member Constructor = 1369737882

    type updateNewAuthorization = 
        {_auth_key_id : int64; _date : int; _device : string; _location : string} with
        static member Constructor = -1895411046

    type updateNewEncryptedMessage = 
        {_message : EncryptedMessage; _qts : int} with
        static member Constructor = 314359194

    type updateEncryptedChatTyping = 
        {_chat_id : int} with
        static member Constructor = 386986326

    type updateEncryption = 
        {_chat : EncryptedChat; _date : int} with
        static member Constructor = -1264392051

    type updateEncryptedMessagesRead = 
        {_chat_id : int; _max_date : int; _date : int} with
        static member Constructor = 956179895

    type updateChatParticipantAdd = 
        {_chat_id : int; _user_id : int; _inviter_id : int; _version : int} with
        static member Constructor = 974056226

    type updateChatParticipantDelete = 
        {_chat_id : int; _user_id : int; _version : int} with
        static member Constructor = 1851755554

    type updateDcOptions = 
        {_dc_options : Vector<DcOption>} with
        static member Constructor = -1906403213

    type updateUserBlocked = 
        {_user_id : int; _blocked : Bool} with
        static member Constructor = -2131957734

    type updateNotifySettings = 
        {_peer : NotifyPeer; _notify_settings : PeerNotifySettings} with
        static member Constructor = -1094555409

    type updateServiceNotification = 
        {_type : string; _message : string; _media : MessageMedia; _popup : Bool} with
        static member Constructor = 942527460

    type updatePrivacy = 
        {_key : PrivacyKey; _rules : Vector<PrivacyRule>} with
        static member Constructor = -298113238

    type updateUserPhone = 
        {_user_id : int; _phone : string} with
        static member Constructor = 314130811

    type Update = 
        |UpdateNewMessage of updateNewMessage 
        |UpdateMessageID of updateMessageID 
        |UpdateReadMessages of updateReadMessages 
        |UpdateDeleteMessages of updateDeleteMessages 
        |UpdateUserTyping of updateUserTyping 
        |UpdateChatUserTyping of updateChatUserTyping 
        |UpdateChatParticipants of updateChatParticipants 
        |UpdateUserStatus of updateUserStatus 
        |UpdateUserName of updateUserName 
        |UpdateUserPhoto of updateUserPhoto 
        |UpdateContactRegistered of updateContactRegistered 
        |UpdateContactLink of updateContactLink 
        |UpdateNewAuthorization of updateNewAuthorization 
        |UpdateNewEncryptedMessage of updateNewEncryptedMessage 
        |UpdateEncryptedChatTyping of updateEncryptedChatTyping 
        |UpdateEncryption of updateEncryption 
        |UpdateEncryptedMessagesRead of updateEncryptedMessagesRead 
        |UpdateChatParticipantAdd of updateChatParticipantAdd 
        |UpdateChatParticipantDelete of updateChatParticipantDelete 
        |UpdateDcOptions of updateDcOptions 
        |UpdateUserBlocked of updateUserBlocked 
        |UpdateNotifySettings of updateNotifySettings 
        |UpdateServiceNotification of updateServiceNotification 
        |UpdatePrivacy of updatePrivacy 
        |UpdateUserPhone of updateUserPhone 

    type updates_differenceEmpty = 
        {_date : int; _seq : int} with
        static member Constructor = 1567990072

    type updates_difference = 
        {_new_messages : Vector<Message>; _new_encrypted_messages : Vector<EncryptedMessage>; _other_updates : Vector<Update>; _chats : Vector<Chat>; _users : Vector<User>; _state : updates_State} with
        static member Constructor = 16030880

    type updates_differenceSlice = 
        {_new_messages : Vector<Message>; _new_encrypted_messages : Vector<EncryptedMessage>; _other_updates : Vector<Update>; _chats : Vector<Chat>; _users : Vector<User>; _intermediate_state : updates_State} with
        static member Constructor = -1459938943

    type updates_Difference = 
        |Updates_differenceEmpty of updates_differenceEmpty 
        |Updates_difference of updates_difference 
        |Updates_differenceSlice of updates_differenceSlice 

    type updatesTooLong = 
        static member Constructor = -484987010

    type updateShortMessage = 
        {_id : int; _from_id : int; _message : string; _pts : int; _date : int; _seq : int} with
        static member Constructor = -738961532

    type updateShortChatMessage = 
        {_id : int; _from_id : int; _chat_id : int; _message : string; _pts : int; _date : int; _seq : int} with
        static member Constructor = 724548942

    type updateShort = 
        {_update : Update; _date : int} with
        static member Constructor = 2027216577

    type updatesCombined = 
        {_updates : Vector<Update>; _users : Vector<User>; _chats : Vector<Chat>; _date : int; _seq_start : int; _seq : int} with
        static member Constructor = 1918567619

    type updates = 
        {_updates : Vector<Update>; _users : Vector<User>; _chats : Vector<Chat>; _date : int; _seq : int} with
        static member Constructor = 1957577280

    type Updates = 
        |UpdatesTooLong of updatesTooLong 
        |UpdateShortMessage of updateShortMessage 
        |UpdateShortChatMessage of updateShortChatMessage 
        |UpdateShort of updateShort 
        |UpdatesCombined of updatesCombined 
        |Updates of updates 
