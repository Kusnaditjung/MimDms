// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.18239 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Dms.Ambulance.V2100</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Dms.Ambulance.V2100 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.18239")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:hl7-org:v3", IsNullable=false)]
    public enum JobRoleName_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Medical Director")]
        MedicalDirector,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Clinical Director - Medical")]
        ClinicalDirectorMedical,
        
        /// <remarks/>
        Professor,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Senior Lecturer")]
        SeniorLecturer,
        
        /// <remarks/>
        Consultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dental surgeon acting as Hospital Consultant")]
        DentalsurgeonactingasHospitalConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Special salary scale in Public Health Medicine")]
        SpecialsalaryscaleinPublicHealthMedicine,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Associate Specialist")]
        AssociateSpecialist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Staff Grade")]
        StaffGrade,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Hospital Practitioner")]
        HospitalPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Clinical Assistant")]
        ClinicalAssistant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Specialist Registrar")]
        SpecialistRegistrar,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Senior Registrar (Closed )")]
        SeniorRegistrarClosed,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Registrar (Closed)")]
        RegistrarClosed,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Senior House Officer")]
        SeniorHouseOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("House Officer - Pre Registration")]
        HouseOfficerPreRegistration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("House Officer - Post Registration")]
        HouseOfficerPostRegistration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Trust Grade Doctor - House Officer level")]
        TrustGradeDoctorHouseOfficerlevel,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Trust Grade Doctor - SHO level")]
        TrustGradeDoctorSHOlevel,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Trust Grade Doctor - Specialist Registrar level")]
        TrustGradeDoctorSpecialistRegistrarlevel,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Trust Grade Doctor - Career Grade level")]
        TrustGradeDoctorCareerGradelevel,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Director of Public Health")]
        DirectorofPublicHealth,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Asst. Clinical Medical Officer")]
        AsstClinicalMedicalOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Clinical Medical Officer")]
        ClinicalMedicalOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Senior Clinical Medical Officer")]
        SeniorClinicalMedicalOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("\'Other\' Community Health Service")]
        OtherCommunityHealthService,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other\' Community Health Service - Social Care Worker")]
        OtherCommunityHealthServiceSocialCareWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other\' Community Health Service - Admin Clerk")]
        OtherCommunityHealthServiceAdminClerk,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("General Dental Practitioner")]
        GeneralDentalPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("General Medical Practitioner")]
        GeneralMedicalPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Salaried General Practitioner")]
        SalariedGeneralPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Regional Dental Officer")]
        RegionalDentalOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dental Clinical Director - Dental")]
        DentalClinicalDirectorDental,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dental Assistant Clinical Director")]
        DentalAssistantClinicalDirector,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dental Officer")]
        DentalOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Senior Dental Officer")]
        SeniorDentalOfficer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Salaried Dental Practitioner")]
        SalariedDentalPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Nurse - Adult Branch")]
        StudentNurseAdultBranch,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Nurse - Child Branch")]
        StudentNurseChildBranch,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Nurse - Mental Health Branch")]
        StudentNurseMentalHealthBranch,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Nurse - Learning Disabilities Branch")]
        StudentNurseLearningDisabilitiesBranch,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Midwife")]
        StudentMidwife,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Health Visitor")]
        StudentHealthVisitor,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student District Nurse")]
        StudentDistrictNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student School Nurse")]
        StudentSchoolNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Practice Nurse")]
        StudentPracticeNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Occupational Health Nurse")]
        StudentOccupationalHealthNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Community Paediatric Nurse")]
        StudentCommunityPaediatricNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Community Mental Health Nurse")]
        StudentCommunityMentalHealthNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Community Learning Disabilities Nurse")]
        StudentCommunityLearningDisabilitiesNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Chiropodist")]
        StudentChiropodist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Dietitian")]
        StudentDietitian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Occupational Therapist")]
        StudentOccupationalTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Orthoptist")]
        StudentOrthoptist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Physiotherapist")]
        StudentPhysiotherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Radiographer - Diagnostic")]
        StudentRadiographerDiagnostic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Radiographer - Therapeutic")]
        StudentRadiographerTherapeutic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Speech & Language Therapist")]
        StudentSpeechLanguageTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Art, Music & Drama Student")]
        ArtMusicDramaStudent,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Psychotherapist")]
        StudentPsychotherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Director of Nursing")]
        DirectorofNursing,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nurse Consultant")]
        NurseConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nurse Manager")]
        NurseManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Modern Matron")]
        ModernMatron,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Specialist Nurse Practitioner")]
        SpecialistNursePractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sister/Charge Nurse")]
        SisterChargeNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Staff Nurse")]
        StaffNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Enrolled Nurse")]
        EnrolledNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Midwife - Consultant")]
        MidwifeConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Midwife - Specialist Practitioner")]
        MidwifeSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Midwife - Manager")]
        MidwifeManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Midwife - Sister/Charge Nurse")]
        MidwifeSisterChargeNurse,
        
        /// <remarks/>
        Midwife,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Community Practitioner")]
        CommunityPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Community Nurse")]
        CommunityNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Art Therapist")]
        ArtTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Art Therapist Consultant")]
        ArtTherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Art Therapist Manager")]
        ArtTherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Art Therapist Specialist Practitioner")]
        ArtTherapistSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chiropodist/Podiatrist")]
        ChiropodistPodiatrist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chiropodist/Podiatrist Consultant")]
        ChiropodistPodiatristConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chiropodist/Podiatrist Manager")]
        ChiropodistPodiatristManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chiropodist/Podiatrist Specialist Practitioner")]
        ChiropodistPodiatristSpecialistPractitioner,
        
        /// <remarks/>
        Dietitian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dietitian Consultant")]
        DietitianConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dietitian Manager")]
        DietitianManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dietitian Specialist Practitioner")]
        DietitianSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Drama Therapist")]
        DramaTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Drama Therapist Consultant")]
        DramaTherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Drama Therapist Manager")]
        DramaTherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Drama Therapist Specialist Practitioner")]
        DramaTherapistSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Multi Therapist")]
        MultiTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Multi Therapist Consultant")]
        MultiTherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Multi Therapist Manager")]
        MultiTherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Multi Therapist Specialist Practitioner")]
        MultiTherapistSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Music Therapist")]
        MusicTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Music Therapist Consultant")]
        MusicTherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Music Therapist Manager")]
        MusicTherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Music Therapist Specialist Practitioner")]
        MusicTherapistSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Occupational Therapist")]
        OccupationalTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Speech & Language Therapist")]
        SpeechLanguageTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Occupational Therapist Consultant")]
        OccupationalTherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Speech & Language Therapist Consultant")]
        SpeechLanguageTherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Occupational Therapist Manager")]
        OccupationalTherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Speech & Language Therapist Manager")]
        SpeechLanguageTherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Occupational Therapy Specialist Practitioner")]
        OccupationalTherapySpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Speech & Language Therapist Specialist Practitioner")]
        SpeechLanguageTherapistSpecialistPractitioner,
        
        /// <remarks/>
        Orthoptist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Orthoptist Consultant")]
        OrthoptistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Orthoptist Manager")]
        OrthoptistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Orthoptist Specialist Practitioner")]
        OrthoptistSpecialistPractitioner,
        
        /// <remarks/>
        Orthotist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Orthotist Consultant")]
        OrthotistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Orthotist Manager")]
        OrthotistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Orthotist Specialist Practitioner")]
        OrthotistSpecialistPractitioner,
        
        /// <remarks/>
        Paramedic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Paramedic Consultant")]
        ParamedicConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Paramedic Manager")]
        ParamedicManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Paramedic Specialist Practitioner")]
        ParamedicSpecialistPractitioner,
        
        /// <remarks/>
        Physiotherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Physiotherapist Consultant")]
        PhysiotherapistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Physiotherapist Manager")]
        PhysiotherapistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Physiotherapist Specialist Practitioner")]
        PhysiotherapistSpecialistPractitioner,
        
        /// <remarks/>
        Prosthetist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prosthetist Consultant")]
        ProsthetistConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prosthetist Manager")]
        ProsthetistManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prosthetist Specialist Practitioner")]
        ProsthetistSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Diagnostic")]
        RadiographerDiagnostic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Diagnostic, Consultant")]
        RadiographerDiagnosticConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Diagnostic, Manager")]
        RadiographerDiagnosticManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Diagnostic, Specialist Practitioner")]
        RadiographerDiagnosticSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Therapeutic")]
        RadiographerTherapeutic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Therapeutic, Consultant")]
        RadiographerTherapeuticConsultant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Therapeutic, Manager")]
        RadiographerTherapeuticManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radiographer - Therapeutic, Specialist Practitioner")]
        RadiographerTherapeuticSpecialistPractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Clinical Director")]
        ClinicalDirector,
        
        /// <remarks/>
        Optometrist,
        
        /// <remarks/>
        Pharmacist,
        
        /// <remarks/>
        Psychotherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Clinical Psychologist")]
        ClinicalPsychologist,
        
        /// <remarks/>
        Chaplain,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Social Worker")]
        SocialWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Approved Social Worker")]
        ApprovedSocialWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Youth Worker")]
        YouthWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Specialist Practitioner")]
        SpecialistPractitioner,
        
        /// <remarks/>
        Practitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Technician - PS&T")]
        TechnicianPST,
        
        /// <remarks/>
        Osteopath,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Healthcare Scientist")]
        HealthcareScientist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Consultant Healthcare Scientist")]
        ConsultantHealthcareScientist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Biomedical Scientist")]
        BiomedicalScientist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Technician - Healthcare Scientists")]
        TechnicianHealthcareScientists,
        
        /// <remarks/>
        Therapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Health Care Support Worker")]
        HealthCareSupportWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Social Care Support Worker")]
        SocialCareSupportWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Home Help")]
        HomeHelp,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Healthcare Assistant")]
        HealthcareAssistant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nursery Nurse")]
        NurseryNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Play Therapist")]
        PlayTherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Play Specialist")]
        PlaySpecialist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Technician - Add\'l Clinical Services")]
        TechnicianAddlClinicalServices,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Technical Instructor")]
        TechnicalInstructor,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Associate Practitioner")]
        AssociatePractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Associate Practitioner - Nurse")]
        AssociatePractitionerNurse,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Associate Practitioner - General Practitioner")]
        AssociatePractitionerGeneralPractitioner,
        
        /// <remarks/>
        Counsellor,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Helper/Assistant")]
        HelperAssistant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dental Surgery Assistant")]
        DentalSurgeryAssistant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Medical Laboratory Assistant")]
        MedicalLaboratoryAssistant,
        
        /// <remarks/>
        Phlebotomist,
        
        /// <remarks/>
        Cytoscreener,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Student Technician")]
        StudentTechnician,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Trainee Scientist")]
        TraineeScientist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Trainee Practitioner")]
        TraineePractitioner,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nursing Cadet")]
        NursingCadet,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Healthcare Cadet")]
        HealthcareCadet,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pre-reg Pharmacist")]
        PreregPharmacist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Assistant Psychologist")]
        AssistantPsychologist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Assistant Psychotherapist")]
        AssistantPsychotherapist,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Call Operator")]
        CallOperator,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Gateway Worker")]
        GatewayWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Support, Time, Recovery Worker")]
        SupportTimeRecoveryWorker,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Clerical Worker")]
        ClericalWorker,
        
        /// <remarks/>
        Receptionist,
        
        /// <remarks/>
        Secretary,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Personal Assistant")]
        PersonalAssistant,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Medical Secretary")]
        MedicalSecretary,
        
        /// <remarks/>
        Officer,
        
        /// <remarks/>
        Manager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Senior Manager")]
        SeniorManager,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Technician - Admin & Clerical")]
        TechnicianAdminClerical,
        
        /// <remarks/>
        Accountant,
        
        /// <remarks/>
        Librarian,
        
        /// <remarks/>
        Interpreter,
        
        /// <remarks/>
        Analyst,
        
        /// <remarks/>
        Adviser,
        
        /// <remarks/>
        Researcher,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Control Assistant")]
        ControlAssistant,
        
        /// <remarks/>
        Architect,
        
        /// <remarks/>
        Lawyer,
        
        /// <remarks/>
        Surveyor,
        
        /// <remarks/>
        Chair,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chief Executive")]
        ChiefExecutive,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Finance Director")]
        FinanceDirector,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other Executive Director")]
        OtherExecutiveDirector,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Board Level Director")]
        BoardLevelDirector,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Non Executive Director")]
        NonExecutiveDirector,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Childcare Co-ordinator")]
        ChildcareCoordinator,
    }
}
