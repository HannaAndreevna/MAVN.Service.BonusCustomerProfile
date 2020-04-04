// <auto-generated />
using System;
using MAVN.Service.BonusCustomerProfile.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.BonusCustomerProfile.MsSqlRepositories.Migrations
{
    [DbContext(typeof(BonusCustomerProfileContext))]
    partial class BonusCustomerProfileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("bonus_customer_profile")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.BonusCustomerProfile.MsSqlRepositories.Entities.CampaignsContribution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("CampaignId")
                        .HasColumnName("campaign_id");

                    b.Property<Guid>("CustomerId")
                        .HasColumnName("customer_id");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId", "CampaignId");

                    b.ToTable("campaigns_contribution");
                });

            modelBuilder.Entity("MAVN.Service.BonusCustomerProfile.MsSqlRepositories.Entities.CustomerProfile", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<int>("TotalCampaignsContributedCount")
                        .HasColumnName("total_campaigns_contributed_count");

                    b.Property<decimal>("TotalHotelReferralStayAmount")
                        .HasColumnName("total_hotel_referral_stay_amount");

                    b.Property<int>("TotalHotelReferralStayCount")
                        .HasColumnName("total_hotel_referral_stay");

                    b.Property<decimal>("TotalHotelStayAmount")
                        .HasColumnName("total_hotel_stay_amount");

                    b.Property<int>("TotalHotelStayCount")
                        .HasColumnName("total_hotel_stay_count");

                    b.Property<int>("TotalOfferToPurchaseByLeadCount")
                        .HasColumnName("total_offer_to_purchases_by_lead_count");

                    b.Property<decimal>("TotalPropertyPurchasesByLeadAmount")
                        .HasColumnName("total_property_purchases_by_lead_amount");

                    b.Property<int>("TotalPropertyPurchasesByLeadCount")
                        .HasColumnName("total_property_purchases_by_lead_count");

                    b.Property<decimal>("TotalPurchasedAmount")
                        .HasColumnName("total_purchased_amount");

                    b.Property<int>("TotalReferredEstateLeadsCount")
                        .HasColumnName("total_referred_estate_leads_count");

                    b.Property<decimal>("TotalReferredEstatePurchasesAmount")
                        .HasColumnName("total_referred_estate_purchases_amount");

                    b.Property<int>("TotalReferredEstatePurchasesCount")
                        .HasColumnName("total_referred_estate_purchases_count");

                    b.Property<int>("TotalReferredFriendCount")
                        .HasColumnName("total_referred_friend_count");

                    b.Property<int>("TotalReferredPurchaseCount")
                        .HasColumnName("total_referred_purchase_count");

                    b.Property<decimal>("TotalReferredPurchasedAmount")
                        .HasColumnName("total_referred_purchase_amount");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("customer_profile");
                });
#pragma warning restore 612, 618
        }
    }
}
